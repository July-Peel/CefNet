﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_context_menu_handler_t.cs
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
	/// Implement this structure to handle context menu events. The functions of this
	/// structure will be called on the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefContextMenuHandler : CefBaseRefCounted<cef_context_menu_handler_t>, ICefContextMenuHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnBeforeContextMenuDelegate fnOnBeforeContextMenu = OnBeforeContextMenuImpl;

		private static readonly RunContextMenuDelegate fnRunContextMenu = RunContextMenuImpl;

		private static readonly OnContextMenuCommandDelegate fnOnContextMenuCommand = OnContextMenuCommandImpl;

		private static readonly OnContextMenuDismissedDelegate fnOnContextMenuDismissed = OnContextMenuDismissedImpl;

		private static readonly RunQuickMenuDelegate fnRunQuickMenu = RunQuickMenuImpl;

		private static readonly OnQuickMenuCommandDelegate fnOnQuickMenuCommand = OnQuickMenuCommandImpl;

		private static readonly OnQuickMenuDismissedDelegate fnOnQuickMenuDismissed = OnQuickMenuDismissedImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefContextMenuHandler Create(IntPtr instance)
		{
			return new CefContextMenuHandler((cef_context_menu_handler_t*)instance);
		}

		public CefContextMenuHandler()
		{
			cef_context_menu_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_before_context_menu = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeContextMenu);
			self->run_context_menu = (void*)Marshal.GetFunctionPointerForDelegate(fnRunContextMenu);
			self->on_context_menu_command = (void*)Marshal.GetFunctionPointerForDelegate(fnOnContextMenuCommand);
			self->on_context_menu_dismissed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnContextMenuDismissed);
			self->run_quick_menu = (void*)Marshal.GetFunctionPointerForDelegate(fnRunQuickMenu);
			self->on_quick_menu_command = (void*)Marshal.GetFunctionPointerForDelegate(fnOnQuickMenuCommand);
			self->on_quick_menu_dismissed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnQuickMenuDismissed);
			#else
			self->on_before_context_menu = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, cef_context_menu_params_t*, cef_menu_model_t*, void>)&OnBeforeContextMenuImpl;
			self->run_context_menu = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, cef_context_menu_params_t*, cef_menu_model_t*, cef_run_context_menu_callback_t*, int>)&RunContextMenuImpl;
			self->on_context_menu_command = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, cef_context_menu_params_t*, int, CefEventFlags, int>)&OnContextMenuCommandImpl;
			self->on_context_menu_dismissed = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, void>)&OnContextMenuDismissedImpl;
			self->run_quick_menu = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, cef_point_t*, cef_size_t*, CefQuickMenuEditStateFlags, cef_run_quick_menu_callback_t*, int>)&RunQuickMenuImpl;
			self->on_quick_menu_command = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, int, CefEventFlags, int>)&OnQuickMenuCommandImpl;
			self->on_quick_menu_dismissed = (delegate* unmanaged[Stdcall]<cef_context_menu_handler_t*, cef_browser_t*, cef_frame_t*, void>)&OnQuickMenuDismissedImpl;
			#endif
		}

		public CefContextMenuHandler(cef_context_menu_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidOnBeforeContextMenu();

		/// <summary>
		/// Called before a context menu is displayed. |params| provides information
		/// about the context menu state. |model| initially contains the default
		/// context menu. The |model| can be cleared to show no context menu or
		/// modified to show a custom menu. Do not keep references to |params| or
		/// |model| outside of this callback.
		/// </summary>
		protected internal unsafe virtual void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, CefMenuModel model)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBeforeContextMenuDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model);

#endif // NET_LESS_5_0
		// void (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, _cef_menu_model_t* model)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnBeforeContextMenuImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidOnBeforeContextMenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)@params);
				ReleaseIfNonNull((cef_base_ref_counted_t*)model);
				return;
			}
			instance.OnBeforeContextMenu(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefContextMenuParams.Wrap(CefContextMenuParams.Create, @params), CefMenuModel.Wrap(CefMenuModel.Create, model));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidRunContextMenu();

		/// <summary>
		/// Called to allow custom display of the context menu. |params| provides
		/// information about the context menu state. |model| contains the context menu
		/// model resulting from OnBeforeContextMenu. For custom display return true
		/// (1) and execute |callback| either synchronously or asynchronously with the
		/// selected command ID. For default display return false (0). Do not keep
		/// references to |params| or |model| outside of this callback.
		/// </summary>
		protected internal unsafe virtual bool RunContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, CefMenuModel model, CefRunContextMenuCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int RunContextMenuDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, _cef_menu_model_t* model, _cef_run_context_menu_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int RunContextMenuImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidRunContextMenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)@params);
				ReleaseIfNonNull((cef_base_ref_counted_t*)model);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.RunContextMenu(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefContextMenuParams.Wrap(CefContextMenuParams.Create, @params), CefMenuModel.Wrap(CefMenuModel.Create, model), CefRunContextMenuCallback.Wrap(CefRunContextMenuCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidOnContextMenuCommand();

		/// <summary>
		/// Called to execute a command selected from the context menu. Return true (1)
		/// if the command was handled or false (0) for the default implementation. See
		/// cef_menu_id_t for the command ids that have default implementations. All
		/// user-defined command ids should be between MENU_ID_USER_FIRST and
		/// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
		/// on_before_context_menu(). Do not keep a reference to |params| outside of
		/// this callback.
		/// </summary>
		protected internal unsafe virtual bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams @params, int commandId, CefEventFlags eventFlags)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnContextMenuCommandDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags);

#endif // NET_LESS_5_0
		// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnContextMenuCommandImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidOnContextMenuCommand())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)@params);
				return default;
			}
			return instance.OnContextMenuCommand(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefContextMenuParams.Wrap(CefContextMenuParams.Create, @params), command_id, event_flags) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidOnContextMenuDismissed();

		/// <summary>
		/// Called when the context menu is dismissed irregardless of whether the menu
		/// was canceled or a command was selected.
		/// </summary>
		protected internal unsafe virtual void OnContextMenuDismissed(CefBrowser browser, CefFrame frame)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnContextMenuDismissedDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);

#endif // NET_LESS_5_0
		// void (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnContextMenuDismissedImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidOnContextMenuDismissed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return;
			}
			instance.OnContextMenuDismissed(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidRunQuickMenu();

		/// <summary>
		/// Called to allow custom display of the quick menu for a windowless browser.
		/// |location| is the top left corner of the selected region. |size| is the
		/// size of the selected region. |edit_state_flags| is a combination of flags
		/// that represent the state of the quick menu. Return true (1) if the menu
		/// will be handled and execute |callback| either synchronously or
		/// asynchronously with the selected command ID. Return false (0) to cancel the
		/// menu.
		/// </summary>
		protected internal unsafe virtual bool RunQuickMenu(CefBrowser browser, CefFrame frame, CefPoint location, CefSize size, CefQuickMenuEditStateFlags editStateFlags, CefRunQuickMenuCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int RunQuickMenuDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_point_t* location, cef_size_t* size, CefQuickMenuEditStateFlags edit_state_flags, cef_run_quick_menu_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, const cef_point_t* location, const cef_size_t* size, cef_quick_menu_edit_state_flags_t edit_state_flags, _cef_run_quick_menu_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int RunQuickMenuImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_point_t* location, cef_size_t* size, CefQuickMenuEditStateFlags edit_state_flags, cef_run_quick_menu_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidRunQuickMenu())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.RunQuickMenu(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), *(CefPoint*)location, *(CefSize*)size, edit_state_flags, CefRunQuickMenuCallback.Wrap(CefRunQuickMenuCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidOnQuickMenuCommand();

		/// <summary>
		/// Called to execute a command selected from the quick menu for a windowless
		/// browser. Return true (1) if the command was handled or false (0) for the
		/// default implementation. See cef_menu_id_t for command IDs that have default
		/// implementations.
		/// </summary>
		protected internal unsafe virtual bool OnQuickMenuCommand(CefBrowser browser, CefFrame frame, int commandId, CefEventFlags eventFlags)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnQuickMenuCommandDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int command_id, CefEventFlags event_flags);

#endif // NET_LESS_5_0
		// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, int command_id, cef_event_flags_t event_flags)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnQuickMenuCommandImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, int command_id, CefEventFlags event_flags)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidOnQuickMenuCommand())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return default;
			}
			return instance.OnQuickMenuCommand(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), command_id, event_flags) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefContextMenuHandlerPrivate.AvoidOnQuickMenuDismissed();

		/// <summary>
		/// Called when the quick menu for a windowless browser is dismissed
		/// irregardless of whether the menu was canceled or a command was selected.
		/// </summary>
		protected internal unsafe virtual void OnQuickMenuDismissed(CefBrowser browser, CefFrame frame)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnQuickMenuDismissedDelegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);

#endif // NET_LESS_5_0
		// void (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnQuickMenuDismissedImpl(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame)
		{
			var instance = GetInstance((IntPtr)self) as CefContextMenuHandler;
			if (instance == null || ((ICefContextMenuHandlerPrivate)instance).AvoidOnQuickMenuDismissed())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return;
			}
			instance.OnQuickMenuDismissed(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame));
		}
	}
}
