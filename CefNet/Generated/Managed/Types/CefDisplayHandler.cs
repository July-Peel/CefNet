﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_display_handler_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Implement this structure to handle events related to browser display state.
	/// The functions of this structure will be called on the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefDisplayHandler : CefBaseRefCounted<cef_display_handler_t>, ICefDisplayHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnAddressChangeDelegate fnOnAddressChange = OnAddressChangeImpl;

		private static readonly OnTitleChangeDelegate fnOnTitleChange = OnTitleChangeImpl;

		private static readonly OnFaviconUrlChangeDelegate fnOnFaviconUrlChange = OnFaviconUrlChangeImpl;

		private static readonly OnFullscreenModeChangeDelegate fnOnFullscreenModeChange = OnFullscreenModeChangeImpl;

		private static readonly OnTooltipDelegate fnOnTooltip = OnTooltipImpl;

		private static readonly OnStatusMessageDelegate fnOnStatusMessage = OnStatusMessageImpl;

		private static readonly OnConsoleMessageDelegate fnOnConsoleMessage = OnConsoleMessageImpl;

		private static readonly OnAutoResizeDelegate fnOnAutoResize = OnAutoResizeImpl;

		private static readonly OnLoadingProgressChangeDelegate fnOnLoadingProgressChange = OnLoadingProgressChangeImpl;

		private static readonly OnCursorChangeDelegate fnOnCursorChange = OnCursorChangeImpl;

		private static readonly OnMediaAccessChangeDelegate fnOnMediaAccessChange = OnMediaAccessChangeImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefDisplayHandler Create(IntPtr instance)
		{
			return new CefDisplayHandler((cef_display_handler_t*)instance);
		}

		public CefDisplayHandler()
		{
			cef_display_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_address_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAddressChange);
			self->on_title_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnTitleChange);
			self->on_favicon_urlchange = (void*)Marshal.GetFunctionPointerForDelegate(fnOnFaviconUrlChange);
			self->on_fullscreen_mode_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnFullscreenModeChange);
			self->on_tooltip = (void*)Marshal.GetFunctionPointerForDelegate(fnOnTooltip);
			self->on_status_message = (void*)Marshal.GetFunctionPointerForDelegate(fnOnStatusMessage);
			self->on_console_message = (void*)Marshal.GetFunctionPointerForDelegate(fnOnConsoleMessage);
			self->on_auto_resize = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAutoResize);
			self->on_loading_progress_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnLoadingProgressChange);
			self->on_cursor_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnCursorChange);
			self->on_media_access_change = (void*)Marshal.GetFunctionPointerForDelegate(fnOnMediaAccessChange);
			#else
			self->on_address_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_frame_t*, cef_string_t*, void>)&OnAddressChangeImpl;
			self->on_title_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_string_t*, void>)&OnTitleChangeImpl;
			self->on_favicon_urlchange = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_string_list_t, void>)&OnFaviconUrlChangeImpl;
			self->on_fullscreen_mode_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, int, void>)&OnFullscreenModeChangeImpl;
			self->on_tooltip = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_string_t*, int>)&OnTooltipImpl;
			self->on_status_message = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_string_t*, void>)&OnStatusMessageImpl;
			self->on_console_message = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, CefLogSeverity, cef_string_t*, cef_string_t*, int, int>)&OnConsoleMessageImpl;
			self->on_auto_resize = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, cef_size_t*, int>)&OnAutoResizeImpl;
			self->on_loading_progress_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, double, void>)&OnLoadingProgressChangeImpl;
			self->on_cursor_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, IntPtr, CefCursorType, cef_cursor_info_t*, int>)&OnCursorChangeImpl;
			self->on_media_access_change = (delegate* unmanaged[Stdcall]<cef_display_handler_t*, cef_browser_t*, int, int, void>)&OnMediaAccessChangeImpl;
			#endif
		}

		public CefDisplayHandler(cef_display_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnAddressChange();

		/// <summary>
		/// Called when a frame&apos;s address has changed.
		/// </summary>
		protected internal unsafe virtual void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAddressChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* url);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, const cef_string_t* url)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAddressChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* url)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnAddressChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return;
			}
			instance.OnAddressChange(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefString.Read(url));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnTitleChange();

		/// <summary>
		/// Called when the page title changes.
		/// </summary>
		protected internal unsafe virtual void OnTitleChange(CefBrowser browser, string title)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnTitleChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* title);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, const cef_string_t* title)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnTitleChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* title)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnTitleChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnTitleChange(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(title));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnFaviconUrlChange();

		/// <summary>
		/// Called when the page icon changes.
		/// </summary>
		protected internal unsafe virtual void OnFaviconUrlChange(CefBrowser browser, CefStringList iconUrls)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnFaviconUrlChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_list_t icon_urls);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, cef_string_list_t icon_urls)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnFaviconUrlChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_string_list_t icon_urls)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnFaviconUrlChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnFaviconUrlChange(CefBrowser.Wrap(CefBrowser.Create, browser), CefStringList.Wrap(icon_urls));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnFullscreenModeChange();

		/// <summary>
		/// Called when web content in the page has toggled fullscreen mode. If
		/// |fullscreen| is true (1) the content will automatically be sized to fill
		/// the browser content area. If |fullscreen| is false (0) the content will
		/// automatically return to its original size and position. The client is
		/// responsible for resizing the browser if desired.
		/// </summary>
		protected internal unsafe virtual void OnFullscreenModeChange(CefBrowser browser, bool fullscreen)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnFullscreenModeChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, int fullscreen);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, int fullscreen)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnFullscreenModeChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, int fullscreen)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnFullscreenModeChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnFullscreenModeChange(CefBrowser.Wrap(CefBrowser.Create, browser), fullscreen != 0);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnTooltip();

		/// <summary>
		/// Called when the browser is about to display a tooltip. |text| contains the
		/// text that will be displayed in the tooltip. To handle the display of the
		/// tooltip yourself return true (1). Otherwise, you can optionally modify
		/// |text| and then return false (0) to allow the browser to display the
		/// tooltip. When window rendering is disabled the application is responsible
		/// for drawing tooltips and the return value is ignored.
		/// </summary>
		protected internal unsafe virtual bool OnTooltip(CefBrowser browser, ref string text)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnTooltipDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* text);

#endif // NET_LESS_5_0
		// int (*)(_cef_display_handler_t* self, _cef_browser_t* browser, cef_string_t* text)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnTooltipImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* text)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnTooltip())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			string s_text = CefString.Read(text);
			string s_orig_text = s_text;
			int rv = instance.OnTooltip(CefBrowser.Wrap(CefBrowser.Create, browser), ref s_text) ? 1 : 0;
			if (s_text != s_orig_text)
				CefString.Replace(text, s_text);
			return rv;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnStatusMessage();

		/// <summary>
		/// Called when the browser receives a status message. |value| contains the
		/// text that will be displayed in the status message.
		/// </summary>
		protected internal unsafe virtual void OnStatusMessage(CefBrowser browser, string value)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnStatusMessageDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* value);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, const cef_string_t* value)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnStatusMessageImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_string_t* value)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnStatusMessage())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnStatusMessage(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(value));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnConsoleMessage();

		/// <summary>
		/// Called to display a console message. Return true (1) to stop the message
		/// from being output to the console.
		/// </summary>
		protected internal unsafe virtual bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnConsoleMessageDelegate(cef_display_handler_t* self, cef_browser_t* browser, CefLogSeverity level, cef_string_t* message, cef_string_t* source, int line);

#endif // NET_LESS_5_0
		// int (*)(_cef_display_handler_t* self, _cef_browser_t* browser, cef_log_severity_t level, const cef_string_t* message, const cef_string_t* source, int line)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnConsoleMessageImpl(cef_display_handler_t* self, cef_browser_t* browser, CefLogSeverity level, cef_string_t* message, cef_string_t* source, int line)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnConsoleMessage())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.OnConsoleMessage(CefBrowser.Wrap(CefBrowser.Create, browser), level, CefString.Read(message), CefString.Read(source), line) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnAutoResize();

		/// <summary>
		/// Called when auto-resize is enabled via
		/// cef_browser_host_t::SetAutoResizeEnabled and the contents have auto-
		/// resized. |new_size| will be the desired size in view coordinates. Return
		/// true (1) if the resize was handled or false (0) for default handling.
		/// </summary>
		protected internal unsafe virtual bool OnAutoResize(CefBrowser browser, CefSize newSize)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnAutoResizeDelegate(cef_display_handler_t* self, cef_browser_t* browser, cef_size_t* new_size);

#endif // NET_LESS_5_0
		// int (*)(_cef_display_handler_t* self, _cef_browser_t* browser, const cef_size_t* new_size)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnAutoResizeImpl(cef_display_handler_t* self, cef_browser_t* browser, cef_size_t* new_size)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnAutoResize())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.OnAutoResize(CefBrowser.Wrap(CefBrowser.Create, browser), *(CefSize*)new_size) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnLoadingProgressChange();

		/// <summary>
		/// Called when the overall page loading progress has changed. |progress|
		/// ranges from 0.0 to 1.0.
		/// </summary>
		protected internal unsafe virtual void OnLoadingProgressChange(CefBrowser browser, double progress)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnLoadingProgressChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, double progress);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, double progress)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnLoadingProgressChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, double progress)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnLoadingProgressChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnLoadingProgressChange(CefBrowser.Wrap(CefBrowser.Create, browser), progress);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnCursorChange();

		/// <summary>
		/// Called when the browser&apos;s cursor has changed. If |type| is CT_CUSTOM then
		/// |custom_cursor_info| will be populated with the custom cursor information.
		/// Return true (1) if the cursor change was handled or false (0) for default
		/// handling.
		/// </summary>
		protected internal unsafe virtual bool OnCursorChange(CefBrowser browser, IntPtr cursor, CefCursorType type, CefCursorInfo customCursorInfo)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnCursorChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, IntPtr cursor, CefCursorType type, cef_cursor_info_t* custom_cursor_info);

#endif // NET_LESS_5_0
		// int (*)(_cef_display_handler_t* self, _cef_browser_t* browser, HCURSOR cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnCursorChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, IntPtr cursor, CefCursorType type, cef_cursor_info_t* custom_cursor_info)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnCursorChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.OnCursorChange(CefBrowser.Wrap(CefBrowser.Create, browser), cursor, type, *(CefCursorInfo*)custom_cursor_info) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefDisplayHandlerPrivate.AvoidOnMediaAccessChange();

		/// <summary>
		/// Called when the browser&apos;s access to an audio and/or video source has
		/// changed.
		/// </summary>
		protected internal unsafe virtual void OnMediaAccessChange(CefBrowser browser, bool hasVideoAccess, bool hasAudioAccess)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnMediaAccessChangeDelegate(cef_display_handler_t* self, cef_browser_t* browser, int has_video_access, int has_audio_access);

#endif // NET_LESS_5_0
		// void (*)(_cef_display_handler_t* self, _cef_browser_t* browser, int has_video_access, int has_audio_access)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnMediaAccessChangeImpl(cef_display_handler_t* self, cef_browser_t* browser, int has_video_access, int has_audio_access)
		{
			var instance = GetInstance((IntPtr)self) as CefDisplayHandler;
			if (instance == null || ((ICefDisplayHandlerPrivate)instance).AvoidOnMediaAccessChange())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnMediaAccessChange(CefBrowser.Wrap(CefBrowser.Create, browser), has_video_access != 0, has_audio_access != 0);
		}
	}
}
