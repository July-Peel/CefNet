﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/internal/cef_types.h
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
	/// Initialization settings. Specify NULL or 0 to get the recommended default
	/// values. Many of these and other settings can also configured using command-
	/// line switches.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_settings_t
	{
		/// <summary>
		/// Size of this structure.
		/// </summary>
		public UIntPtr size;

		/// <summary>
		/// Set to true (1) to disable the sandbox for sub-processes. See
		/// cef_sandbox_win.h for requirements to enable the sandbox on Windows. Also
		/// configurable using the &quot;no-sandbox&quot; command-line switch.
		/// </summary>
		public int no_sandbox;

		/// <summary>
		/// The path to a separate executable that will be launched for sub-processes.
		/// If this value is empty on Windows or Linux then the main process executable
		/// will be used. If this value is empty on macOS then a helper executable must
		/// exist at &quot;Contents/Frameworks/
		/// &lt;app
		/// &gt; Helper.app/Contents/MacOS/
		/// &lt;app
		/// &gt; Helper&quot;
		/// in the top-level app bundle. See the comments on CefExecuteProcess() for
		/// details. If this value is non-empty then it must be an absolute path. Also
		/// configurable using the &quot;browser-subprocess-path&quot; command-line switch.
		/// </summary>
		public cef_string_t browser_subprocess_path;

		/// <summary>
		/// The path to the CEF framework directory on macOS. If this value is empty
		/// then the framework must exist at &quot;Contents/Frameworks/Chromium Embedded
		/// Framework.framework&quot; in the top-level app bundle. If this value is
		/// non-empty then it must be an absolute path. Also configurable using the
		/// &quot;framework-dir-path&quot; command-line switch.
		/// </summary>
		public cef_string_t framework_dir_path;

		/// <summary>
		/// The path to the main bundle on macOS. If this value is empty then it
		/// defaults to the top-level app bundle. If this value is non-empty then it
		/// must be an absolute path. Also configurable using the &quot;main-bundle-path&quot;
		/// command-line switch.
		/// </summary>
		public cef_string_t main_bundle_path;

		/// <summary>
		/// Set to true (1) to enable use of the Chrome runtime in CEF. This feature is
		/// considered experimental and is not recommended for most users at this time.
		/// See issue #2969 for details.
		/// </summary>
		public int chrome_runtime;

		/// <summary>
		/// Set to true (1) to have the browser process message loop run in a separate
		/// thread. If false (0) then the CefDoMessageLoopWork() function must be
		/// called from your application message loop. This option is only supported on
		/// Windows and Linux.
		/// </summary>
		public int multi_threaded_message_loop;

		/// <summary>
		/// Set to true (1) to control browser process main (UI) thread message pump
		/// scheduling via the CefBrowserProcessHandler::OnScheduleMessagePumpWork()
		/// callback. This option is recommended for use in combination with the
		/// CefDoMessageLoopWork() function in cases where the CEF message loop must be
		/// integrated into an existing application message loop (see additional
		/// comments and warnings on CefDoMessageLoopWork). Enabling this option is not
		/// recommended for most users; leave this option disabled and use either the
		/// CefRunMessageLoop() function or multi_threaded_message_loop if possible.
		/// </summary>
		public int external_message_pump;

		/// <summary>
		/// Set to true (1) to enable windowless (off-screen) rendering support. Do not
		/// enable this value if the application does not use windowless rendering as
		/// it may reduce rendering performance on some systems.
		/// </summary>
		public int windowless_rendering_enabled;

		/// <summary>
		/// Set to true (1) to disable configuration of browser process features using
		/// standard CEF and Chromium command-line arguments. Configuration can still
		/// be specified using CEF data structures or via the
		/// CefApp::OnBeforeCommandLineProcessing() method.
		/// </summary>
		public int command_line_args_disabled;

		/// <summary>
		/// The location where data for the global browser cache will be stored on
		/// disk. If this value is non-empty then it must be an absolute path that is
		/// either equal to or a child directory of CefSettings.root_cache_path. If
		/// this value is empty then browsers will be created in &quot;incognito mode&quot; where
		/// in-memory caches are used for storage and no data is persisted to disk.
		/// HTML5 databases such as localStorage will only persist across sessions if a
		/// cache path is specified. Can be overridden for individual CefRequestContext
		/// instances via the CefRequestContextSettings.cache_path value. When using
		/// the Chrome runtime the &quot;default&quot; profile will be used if |cache_path| and
		/// |root_cache_path| have the same value.
		/// </summary>
		public cef_string_t cache_path;

		/// <summary>
		/// The root directory that all CefSettings.cache_path and
		/// CefRequestContextSettings.cache_path values must have in common. If this
		/// value is empty and CefSettings.cache_path is non-empty then it will
		/// default to the CefSettings.cache_path value. If this value is non-empty
		/// then it must be an absolute path. Failure to set this value correctly may
		/// result in the sandbox blocking read/write access to the cache_path
		/// directory.
		/// </summary>
		public cef_string_t root_cache_path;

		/// <summary>
		/// The location where user data such as the Widevine CDM module and spell
		/// checking dictionary files will be stored on disk. If this value is empty
		/// then the default platform-specific user data directory will be used
		/// (&quot;~/.config/cef_user_data&quot; directory on Linux, &quot;~/Library/Application
		/// Support/CEF/User Data&quot; directory on MacOS, &quot;AppData@Local @CEF @User Data&quot;
		/// directory under the user profile directory on Windows). If this value is
		/// non-empty then it must be an absolute path. When using the Chrome runtime
		/// this value will be ignored in favor of the |root_cache_path| value.
		/// </summary>
		public cef_string_t user_data_path;

		/// <summary>
		/// To persist session cookies (cookies without an expiry date or validity
		/// interval) by default when using the global cookie manager set this value to
		/// true (1). Session cookies are generally intended to be transient and most
		/// Web browsers do not persist them. A |cache_path| value must also be
		/// specified to enable this feature. Also configurable using the
		/// &quot;persist-session-cookies&quot; command-line switch. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.persist_session_cookies value.
		/// </summary>
		public int persist_session_cookies;

		/// <summary>
		/// To persist user preferences as a JSON file in the cache path directory set
		/// this value to true (1). A |cache_path| value must also be specified
		/// to enable this feature. Also configurable using the
		/// &quot;persist-user-preferences&quot; command-line switch. Can be overridden for
		/// individual CefRequestContext instances via the
		/// CefRequestContextSettings.persist_user_preferences value.
		/// </summary>
		public int persist_user_preferences;

		/// <summary>
		/// Value that will be returned as the User-Agent HTTP header. If empty the
		/// default User-Agent string will be used. Also configurable using the
		/// &quot;user-agent&quot; command-line switch.
		/// </summary>
		public cef_string_t user_agent;

		/// <summary>
		/// Value that will be inserted as the product portion of the default
		/// User-Agent string. If empty the Chromium product version will be used. If
		/// |userAgent| is specified this value will be ignored. Also configurable
		/// using the &quot;user-agent-product&quot; command-line switch.
		/// </summary>
		public cef_string_t user_agent_product;

		/// <summary>
		/// The locale string that will be passed to WebKit. If empty the default
		/// locale of &quot;en-US&quot; will be used. This value is ignored on Linux where locale
		/// is determined using environment variable parsing with the precedence order:
		/// LANGUAGE, LC_ALL, LC_MESSAGES and LANG. Also configurable using the &quot;lang&quot;
		/// command-line switch.
		/// </summary>
		public cef_string_t locale;

		/// <summary>
		/// The directory and file name to use for the debug log. If empty a default
		/// log file name and location will be used. On Windows and Linux a &quot;debug.log&quot;
		/// file will be written in the main executable directory. On MacOS a
		/// &quot;~/Library/Logs/
		/// &lt;app
		/// name&gt;_debug.log&quot; file will be written where 
		/// &lt;app
		/// name&gt;
		/// is the name of the main app executable. Also configurable using the
		/// &quot;log-file&quot; command-line switch.
		/// </summary>
		public cef_string_t log_file;

		/// <summary>
		/// The log severity. Only messages of this severity level or higher will be
		/// logged. When set to DISABLE no messages will be written to the log file,
		/// but FATAL messages will still be output to stderr. Also configurable using
		/// the &quot;log-severity&quot; command-line switch with a value of &quot;verbose&quot;, &quot;info&quot;,
		/// &quot;warning&quot;, &quot;error&quot;, &quot;fatal&quot; or &quot;disable&quot;.
		/// </summary>
		public CefLogSeverity log_severity;

		/// <summary>
		/// Custom flags that will be used when initializing the V8 JavaScript engine.
		/// The consequences of using custom flags may not be well tested. Also
		/// configurable using the &quot;js-flags&quot; command-line switch.
		/// </summary>
		public cef_string_t javascript_flags;

		/// <summary>
		/// The fully qualified path for the resources directory. If this value is
		/// empty the *.pak files must be located in the module directory on
		/// Windows/Linux or the app bundle Resources directory on MacOS. If this
		/// value is non-empty then it must be an absolute path. Also configurable
		/// using the &quot;resources-dir-path&quot; command-line switch.
		/// </summary>
		public cef_string_t resources_dir_path;

		/// <summary>
		/// The fully qualified path for the locales directory. If this value is empty
		/// the locales directory must be located in the module directory. If this
		/// value is non-empty then it must be an absolute path. This value is ignored
		/// on MacOS where pack files are always loaded from the app bundle Resources
		/// directory. Also configurable using the &quot;locales-dir-path&quot; command-line
		/// switch.
		/// </summary>
		public cef_string_t locales_dir_path;

		/// <summary>
		/// Set to true (1) to disable loading of pack files for resources and locales.
		/// A resource bundle handler must be provided for the browser and render
		/// processes via CefApp::GetResourceBundleHandler() if loading of pack files
		/// is disabled. Also configurable using the &quot;disable-pack-loading&quot; command-
		/// line switch.
		/// </summary>
		public int pack_loading_disabled;

		/// <summary>
		/// Set to a value between 1024 and 65535 to enable remote debugging on the
		/// specified port. Also configurable using the &quot;remote-debugging-port&quot;
		/// command-line switch. Remote debugging can be accessed by loading the
		/// chrome://inspect page in Google Chrome. Port numbers 9222 and 9229 are
		/// discoverable by default. Other port numbers may need to be configured via
		/// &quot;Discover network targets&quot; on the Devices tab.
		/// </summary>
		public int remote_debugging_port;

		/// <summary>
		/// The number of stack trace frames to capture for uncaught exceptions.
		/// Specify a positive value to enable the CefRenderProcessHandler::
		/// OnUncaughtException() callback. Specify 0 (default value) and
		/// OnUncaughtException() will not be called. Also configurable using the
		/// &quot;uncaught-exception-stack-size&quot; command-line switch.
		/// </summary>
		public int uncaught_exception_stack_size;

		/// <summary>
		/// Background color used for the browser before a document is loaded and when
		/// no document color is specified. The alpha component must be either fully
		/// opaque (0xFF) or fully transparent (0x00). If the alpha component is fully
		/// opaque then the RGB components will be used as the background color. If the
		/// alpha component is fully transparent for a windowed browser then the
		/// default value of opaque white be used. If the alpha component is fully
		/// transparent for a windowless (off-screen) browser then transparent painting
		/// will be enabled.
		/// </summary>
		public cef_color_t background_color;

		/// <summary>
		/// Comma delimited ordered list of language codes without any whitespace that
		/// will be used in the &quot;Accept-Language&quot; HTTP header. May be overridden on a
		/// per-browser basis using the CefBrowserSettings.accept_language_list value.
		/// If both values are empty then &quot;en-US,en&quot; will be used. Can be overridden
		/// for individual CefRequestContext instances via the
		/// CefRequestContextSettings.accept_language_list value.
		/// </summary>
		public cef_string_t accept_language_list;

		/// <summary>
		/// Comma delimited list of schemes supported by the associated
		/// CefCookieManager. If |cookieable_schemes_exclude_defaults| is false (0) the
		/// default schemes (&quot;http&quot;, &quot;https&quot;, &quot;ws&quot; and &quot;wss&quot;) will also be supported.
		/// Specifying a |cookieable_schemes_list| value and setting
		/// |cookieable_schemes_exclude_defaults| to true (1) will disable all loading
		/// and saving of cookies for this manager. Can be overridden
		/// for individual CefRequestContext instances via the
		/// CefRequestContextSettings.cookieable_schemes_list and
		/// CefRequestContextSettings.cookieable_schemes_exclude_defaults values.
		/// </summary>
		public cef_string_t cookieable_schemes_list;

		public int cookieable_schemes_exclude_defaults;
	}
}

