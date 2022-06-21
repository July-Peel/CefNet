﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_audio_handler_t.cs
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
	/// Implement this structure to handle audio events.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefAudioHandler : CefBaseRefCounted<cef_audio_handler_t>, ICefAudioHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly GetAudioParametersDelegate fnGetAudioParameters = GetAudioParametersImpl;

		private static readonly OnAudioStreamStartedDelegate fnOnAudioStreamStarted = OnAudioStreamStartedImpl;

		private static readonly OnAudioStreamPacketDelegate fnOnAudioStreamPacket = OnAudioStreamPacketImpl;

		private static readonly OnAudioStreamStoppedDelegate fnOnAudioStreamStopped = OnAudioStreamStoppedImpl;

		private static readonly OnAudioStreamErrorDelegate fnOnAudioStreamError = OnAudioStreamErrorImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefAudioHandler Create(IntPtr instance)
		{
			return new CefAudioHandler((cef_audio_handler_t*)instance);
		}

		public CefAudioHandler()
		{
			cef_audio_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->get_audio_parameters = (void*)Marshal.GetFunctionPointerForDelegate(fnGetAudioParameters);
			self->on_audio_stream_started = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAudioStreamStarted);
			self->on_audio_stream_packet = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAudioStreamPacket);
			self->on_audio_stream_stopped = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAudioStreamStopped);
			self->on_audio_stream_error = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAudioStreamError);
			#else
			self->get_audio_parameters = (delegate* unmanaged[Stdcall]<cef_audio_handler_t*, cef_browser_t*, cef_audio_parameters_t*, int>)&GetAudioParametersImpl;
			self->on_audio_stream_started = (delegate* unmanaged[Stdcall]<cef_audio_handler_t*, cef_browser_t*, cef_audio_parameters_t*, int, void>)&OnAudioStreamStartedImpl;
			self->on_audio_stream_packet = (delegate* unmanaged[Stdcall]<cef_audio_handler_t*, cef_browser_t*, float**, int, long, void>)&OnAudioStreamPacketImpl;
			self->on_audio_stream_stopped = (delegate* unmanaged[Stdcall]<cef_audio_handler_t*, cef_browser_t*, void>)&OnAudioStreamStoppedImpl;
			self->on_audio_stream_error = (delegate* unmanaged[Stdcall]<cef_audio_handler_t*, cef_browser_t*, cef_string_t*, void>)&OnAudioStreamErrorImpl;
			#endif
		}

		public CefAudioHandler(cef_audio_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefAudioHandlerPrivate.AvoidGetAudioParameters();

		/// <summary>
		/// Called on the UI thread to allow configuration of audio stream parameters.
		/// Return true (1) to proceed with audio stream capture, or false (0) to
		/// cancel it. All members of |params| can optionally be configured here, but
		/// they are also pre-filled with some sensible defaults.
		/// </summary>
		protected internal unsafe virtual bool GetAudioParameters(CefBrowser browser, ref CefAudioParameters @params)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int GetAudioParametersDelegate(cef_audio_handler_t* self, cef_browser_t* browser, cef_audio_parameters_t* @params);

#endif // NET_LESS_5_0
		// int (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, cef_audio_parameters_t* params)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int GetAudioParametersImpl(cef_audio_handler_t* self, cef_browser_t* browser, cef_audio_parameters_t* @params)
		{
			var instance = GetInstance((IntPtr)self) as CefAudioHandler;
			if (instance == null || ((ICefAudioHandlerPrivate)instance).AvoidGetAudioParameters())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.GetAudioParameters(CefBrowser.Wrap(CefBrowser.Create, browser), ref *(CefAudioParameters*)@params) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefAudioHandlerPrivate.AvoidOnAudioStreamStarted();

		/// <summary>
		/// Called on a browser audio capture thread when the browser starts streaming
		/// audio. OnAudioStreamStopped will always be called after
		/// OnAudioStreamStarted; both functions may be called multiple times for the
		/// same browser. |params| contains the audio parameters like sample rate and
		/// channel layout. |channels| is the number of channels.
		/// </summary>
		protected internal unsafe virtual void OnAudioStreamStarted(CefBrowser browser, CefAudioParameters @params, int channels)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAudioStreamStartedDelegate(cef_audio_handler_t* self, cef_browser_t* browser, cef_audio_parameters_t* @params, int channels);

#endif // NET_LESS_5_0
		// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const cef_audio_parameters_t* params, int channels)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAudioStreamStartedImpl(cef_audio_handler_t* self, cef_browser_t* browser, cef_audio_parameters_t* @params, int channels)
		{
			var instance = GetInstance((IntPtr)self) as CefAudioHandler;
			if (instance == null || ((ICefAudioHandlerPrivate)instance).AvoidOnAudioStreamStarted())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnAudioStreamStarted(CefBrowser.Wrap(CefBrowser.Create, browser), *(CefAudioParameters*)@params, channels);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefAudioHandlerPrivate.AvoidOnAudioStreamPacket();

		/// <summary>
		/// Called on the audio stream thread when a PCM packet is received for the
		/// stream. |data| is an array representing the raw PCM data as a floating
		/// point type, i.e. 4-byte value(s). |frames| is the number of frames in the
		/// PCM packet. |pts| is the presentation timestamp (in milliseconds since the
		/// Unix Epoch) and represents the time at which the decompressed packet should
		/// be presented to the user. Based on |frames| and the |channel_layout| value
		/// passed to OnAudioStreamStarted you can calculate the size of the |data|
		/// array in bytes.
		/// </summary>
		protected internal unsafe virtual void OnAudioStreamPacket(CefBrowser browser, IntPtr data, int frames, long pts)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAudioStreamPacketDelegate(cef_audio_handler_t* self, cef_browser_t* browser, float** data, int frames, long pts);

#endif // NET_LESS_5_0
		// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const float** data, int frames, int64 pts)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAudioStreamPacketImpl(cef_audio_handler_t* self, cef_browser_t* browser, float** data, int frames, long pts)
		{
			var instance = GetInstance((IntPtr)self) as CefAudioHandler;
			if (instance == null || ((ICefAudioHandlerPrivate)instance).AvoidOnAudioStreamPacket())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnAudioStreamPacket(CefBrowser.Wrap(CefBrowser.Create, browser), (IntPtr)data, frames, pts);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefAudioHandlerPrivate.AvoidOnAudioStreamStopped();

		/// <summary>
		/// Called on the UI thread when the stream has stopped. OnAudioSteamStopped
		/// will always be called after OnAudioStreamStarted; both functions may be
		/// called multiple times for the same stream.
		/// </summary>
		protected internal unsafe virtual void OnAudioStreamStopped(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAudioStreamStoppedDelegate(cef_audio_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAudioStreamStoppedImpl(cef_audio_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefAudioHandler;
			if (instance == null || ((ICefAudioHandlerPrivate)instance).AvoidOnAudioStreamStopped())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnAudioStreamStopped(CefBrowser.Wrap(CefBrowser.Create, browser));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefAudioHandlerPrivate.AvoidOnAudioStreamError();

		/// <summary>
		/// Called on the UI or audio stream thread when an error occurred. During the
		/// stream creation phase this callback will be called on the UI thread while
		/// in the capturing phase it will be called on the audio stream thread. The
		/// stream will be stopped immediately.
		/// </summary>
		protected internal unsafe virtual void OnAudioStreamError(CefBrowser browser, string message)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAudioStreamErrorDelegate(cef_audio_handler_t* self, cef_browser_t* browser, cef_string_t* message);

#endif // NET_LESS_5_0
		// void (*)(_cef_audio_handler_t* self, _cef_browser_t* browser, const cef_string_t* message)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAudioStreamErrorImpl(cef_audio_handler_t* self, cef_browser_t* browser, cef_string_t* message)
		{
			var instance = GetInstance((IntPtr)self) as CefAudioHandler;
			if (instance == null || ((ICefAudioHandlerPrivate)instance).AvoidOnAudioStreamError())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnAudioStreamError(CefBrowser.Wrap(CefBrowser.Create, browser), CefString.Read(message));
		}
	}
}
