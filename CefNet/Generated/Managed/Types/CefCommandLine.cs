﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_command_line_t.cs
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
	/// Structure used to create and/or parse command line arguments. Arguments with
	/// &apos;--&apos;, &apos;-&apos; and, on Windows, &apos;/&apos; prefixes are considered switches. Switches
	/// will always precede any arguments without switch prefixes. Switches can
	/// optionally have a value specified using the &apos;=&apos; delimiter (e.g.
	/// &quot;-switch=value&quot;). An argument of &quot;--&quot; will terminate switch parsing with all
	/// subsequent tokens, regardless of prefix, being interpreted as non-switch
	/// arguments. Switch names should be lowercase ASCII and will be converted to
	/// such if necessary. Switch values will retain the original case and UTF8
	/// encoding. This structure can be used before cef_initialize() is called.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefCommandLine : CefBaseRefCounted<cef_command_line_t>
	{
		internal static unsafe CefCommandLine Create(IntPtr instance)
		{
			return new CefCommandLine((cef_command_line_t*)instance);
		}

		public CefCommandLine(cef_command_line_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is valid. Do not call any other functions
		/// if this property returns false.
		/// </summary>
		public unsafe virtual bool IsValid
		{
			get
			{
				return SafeCall(NativeInstance->IsValid() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the values of this object are read-only. Some APIs may
		/// expose read-only objects.
		/// </summary>
		public unsafe virtual bool IsReadOnly
		{
			get
			{
				return SafeCall(NativeInstance->IsReadOnly() != 0);
			}
		}

		/// <summary>
		/// Constructs and returns the represented command line string. Use this
		/// function cautiously because quoting behavior is unclear.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string CommandLineString
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetCommandLineString()));
			}
		}

		/// <summary>
		/// Gets and sets the program part of the command line string (the first item).
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Program
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetProgram()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetProgram(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the command line has switches.
		/// </summary>
		public unsafe virtual bool HasSwitches
		{
			get
			{
				return SafeCall(NativeInstance->HasSwitches() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether there are remaining command line arguments.
		/// </summary>
		public unsafe virtual bool HasArguments
		{
			get
			{
				return SafeCall(NativeInstance->HasArguments() != 0);
			}
		}

		/// <summary>
		/// Returns a writable copy of this object.
		/// </summary>
		public unsafe virtual CefCommandLine Copy()
		{
			return SafeCall(CefCommandLine.Wrap(CefCommandLine.Create, NativeInstance->Copy()));
		}

		/// <summary>
		/// Initialize the command line with the specified |argc| and |argv| values.
		/// The first argument must be the name of the program. This function is only
		/// supported on non-Windows platforms.
		/// </summary>
		public unsafe virtual void InitFromArgv(int argc, IntPtr argv)
		{
			NativeInstance->InitFromArgv(argc, (byte**)argv);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Initialize the command line with the string returned by calling
		/// GetCommandLineW(). This function is only supported on Windows.
		/// </summary>
		public unsafe virtual void InitFromString(string commandLine)
		{
			fixed (char* s0 = commandLine)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = commandLine != null ? commandLine.Length : 0 };
				NativeInstance->InitFromString(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Reset the command-line switches and arguments but leave the program
		/// component unchanged.
		/// </summary>
		public unsafe virtual void Reset()
		{
			NativeInstance->Reset();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Retrieve the original command line string as a vector of strings. The argv
		/// array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
		/// </summary>
		public unsafe virtual void GetArgv(CefStringList argv)
		{
			NativeInstance->GetArgv(argv.GetNativeInstance());
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns true (1) if the command line contains the given switch.
		/// </summary>
		public unsafe virtual bool HasSwitch(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(NativeInstance->HasSwitch(&cstr0) != 0);
			}
		}

		/// <summary>
		/// Returns the value associated with the given switch. If the switch has no
		/// value or isn&apos;t present this function returns the NULL string.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string GetSwitchValue(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetSwitchValue(&cstr0)));
			}
		}

		/// <summary>
		/// Returns the map of switch names and values. If a switch has no value an
		/// NULL string is returned.
		/// </summary>
		public unsafe virtual void GetSwitches(CefStringMap switches)
		{
			NativeInstance->GetSwitches(switches);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Add a switch to the end of the command line. If the switch has no value
		/// pass an NULL value string.
		/// </summary>
		public unsafe virtual void AppendSwitch(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				NativeInstance->AppendSwitch(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Add a switch with the specified value to the end of the command line.
		/// </summary>
		public unsafe virtual void AppendSwitchWithValue(string name, string value)
		{
			fixed (char* s0 = name)
			fixed (char* s1 = value)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = value != null ? value.Length : 0 };
				NativeInstance->AppendSwitchWithValue(&cstr0, &cstr1);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Get the remaining command line arguments.
		/// </summary>
		public unsafe virtual void GetArguments(CefStringList arguments)
		{
			NativeInstance->GetArguments(arguments.GetNativeInstance());
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Add an argument to the end of the command line.
		/// </summary>
		public unsafe virtual void AppendArgument(string argument)
		{
			fixed (char* s0 = argument)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = argument != null ? argument.Length : 0 };
				NativeInstance->AppendArgument(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Insert a command before the current command. Common for debuggers, like
		/// &quot;valgrind&quot; or &quot;gdb --args&quot;.
		/// </summary>
		public unsafe virtual void PrependWrapper(string wrapper)
		{
			fixed (char* s0 = wrapper)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = wrapper != null ? wrapper.Length : 0 };
				NativeInstance->PrependWrapper(&cstr0);
			}
			GC.KeepAlive(this);
		}
	}
}
