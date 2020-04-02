﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_media_observer_t.cs
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

namespace CefNet.Internal
{
	sealed partial class CefMediaObserverGlue: CefMediaObserver, ICefMediaObserverPrivate
	{
		private WebViewGlue _implementation;

		public CefMediaObserverGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefMediaObserverPrivate.AvoidOnSinks()
		{
			return _implementation.AvoidOnSinks();
		}

		public override void OnSinks(CefMediaSink[] sinks)
		{
			_implementation.OnSinks(sinks);
		}

		bool ICefMediaObserverPrivate.AvoidOnRoutes()
		{
			return _implementation.AvoidOnRoutes();
		}

		public override void OnRoutes(CefMediaRoute[] routes)
		{
			_implementation.OnRoutes(routes);
		}

		bool ICefMediaObserverPrivate.AvoidOnRouteStateChanged()
		{
			return _implementation.AvoidOnRouteStateChanged();
		}

		public override void OnRouteStateChanged(CefMediaRoute route, CefMediaRouteConnectionState state)
		{
			_implementation.OnRouteStateChanged(route, state);
		}

		bool ICefMediaObserverPrivate.AvoidOnRouteMessageReceived()
		{
			return _implementation.AvoidOnRouteMessageReceived();
		}

		public override void OnRouteMessageReceived(CefMediaRoute route, IntPtr message, long messageSize)
		{
			_implementation.OnRouteMessageReceived(route, message, messageSize);
		}

	}
}
