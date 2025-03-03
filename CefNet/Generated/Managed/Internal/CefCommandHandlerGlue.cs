﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_command_handler_t.cs
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
	sealed partial class CefCommandHandlerGlue: CefCommandHandler, ICefCommandHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefCommandHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefCommandHandlerPrivate.AvoidOnChromeCommand()
		{
			return _implementation.AvoidOnChromeCommand();
		}

		protected internal unsafe override bool OnChromeCommand(CefBrowser browser, int commandId, CefWindowOpenDisposition disposition)
		{
			return _implementation.OnChromeCommand(browser, commandId, disposition);
		}

	}
}
