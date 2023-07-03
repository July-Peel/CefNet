using Avalonia.Input;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CefNet.Internal
{
	public static class CursorInteropHelper
	{
		private static readonly Dictionary<IntPtr, Cursor> _Cursors = new Dictionary<IntPtr, Cursor>();
		private static readonly Dictionary<StandardCursorType, Cursor> _StdCursors = new Dictionary<StandardCursorType, Cursor>();

		private static IntPtr GetPlatformHandle(Cursor cursor)
		{
			if (cursor != null)
			{
				System.Reflection.PropertyInfo Impl = cursor.GetType().GetProperty("PlatformImpl", BindingFlags.Instance | BindingFlags.NonPublic);
				IPlatformHandle data = Impl.GetValue(cursor, null) as IPlatformHandle;
				return data.Handle;
			}
			return default;
		}

		static CursorInteropHelper()
		{
			foreach (StandardCursorType cursorType in Enum.GetValues(typeof(StandardCursorType)))
			{
				var cursor = new Cursor(cursorType);
				IntPtr handle = GetPlatformHandle(cursor);
				if (handle == default || _Cursors.ContainsKey(handle))
					continue;

				_Cursors.Add(handle, cursor);
				_StdCursors.Add(cursorType, cursor);
			}
		}

		public static Cursor Create(IntPtr cursorHandle)
		{
			if (_Cursors.TryGetValue(cursorHandle, out Cursor cursor))
				return cursor;
			return Cursor.Default;
		}

		public static Cursor Create(StandardCursorType cursorType)
		{
			Cursor cursor;
			lock (_StdCursors)
			{
				if (!_StdCursors.TryGetValue(cursorType, out cursor))
				{
					cursor = new Cursor(cursorType);
					_StdCursors[cursorType] = cursor;
				}
			}
			return cursor;
		}
	}
}