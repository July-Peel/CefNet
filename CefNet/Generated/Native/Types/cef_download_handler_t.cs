﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_download_handler_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Structure used to handle file downloads. The functions of this structure will
	/// called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_download_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_download_handler_t* self, _cef_browser_t* browser, const cef_string_t* url, const cef_string_t* request_method)*
		/// </summary>
		public void* can_download;

		/// <summary>
		/// Called before a download begins in response to a user-initiated action
		/// (e.g. alt + link click or link click that returns a `Content-Disposition:
		/// attachment` response from the server). |url| is the target download URL and
		/// |request_function| is the target function (GET, POST, etc). Return true (1)
		/// to proceed with the download or false (0) to cancel the download.
		/// </summary>
		[NativeName("can_download")]
		public unsafe int CanDownload(cef_browser_t* browser, [Immutable]cef_string_t* url, [Immutable]cef_string_t* request_method)
		{
			fixed (cef_download_handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_download_handler_t*, cef_browser_t*, cef_string_t*, cef_string_t*, int>)can_download)(self, browser, url, request_method);
			}
		}

		/// <summary>
		/// void (*)(_cef_download_handler_t* self, _cef_browser_t* browser, _cef_download_item_t* download_item, const cef_string_t* suggested_name, _cef_before_download_callback_t* callback)*
		/// </summary>
		public void* on_before_download;

		/// <summary>
		/// Called before a download begins. |suggested_name| is the suggested name for
		/// the download file. By default the download will be canceled. Execute
		/// |callback| either asynchronously or in this function to continue the
		/// download if desired. Do not keep a reference to |download_item| outside of
		/// this function.
		/// </summary>
		[NativeName("on_before_download")]
		public unsafe void OnBeforeDownload(cef_browser_t* browser, cef_download_item_t* download_item, [Immutable]cef_string_t* suggested_name, cef_before_download_callback_t* callback)
		{
			fixed (cef_download_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_download_handler_t*, cef_browser_t*, cef_download_item_t*, cef_string_t*, cef_before_download_callback_t*, void>)on_before_download)(self, browser, download_item, suggested_name, callback);
			}
		}

		/// <summary>
		/// void (*)(_cef_download_handler_t* self, _cef_browser_t* browser, _cef_download_item_t* download_item, _cef_download_item_callback_t* callback)*
		/// </summary>
		public void* on_download_updated;

		/// <summary>
		/// Called when a download&apos;s status or progress information has been updated.
		/// This may be called multiple times before and after on_before_download().
		/// Execute |callback| either asynchronously or in this function to cancel the
		/// download if desired. Do not keep a reference to |download_item| outside of
		/// this function.
		/// </summary>
		[NativeName("on_download_updated")]
		public unsafe void OnDownloadUpdated(cef_browser_t* browser, cef_download_item_t* download_item, cef_download_item_callback_t* callback)
		{
			fixed (cef_download_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_download_handler_t*, cef_browser_t*, cef_download_item_t*, cef_download_item_callback_t*, void>)on_download_updated)(self, browser, download_item, callback);
			}
		}
	}
}

