﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_x509_certificate_capi.h
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
	/// Structure representing a X.509 certificate.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_x509certificate_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// _cef_x509cert_principal_t* (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_subject;

		/// <summary>
		/// Returns the subject of the X.509 certificate. For HTTPS server certificates
		/// this represents the web server.  The common name of the subject should
		/// match the host name of the web server.
		/// </summary>
		[NativeName("get_subject")]
		public unsafe cef_x509cert_principal_t* GetSubject()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_x509cert_principal_t*>)get_subject)(self);
			}
		}

		/// <summary>
		/// _cef_x509cert_principal_t* (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_issuer;

		/// <summary>
		/// Returns the issuer of the X.509 certificate.
		/// </summary>
		[NativeName("get_issuer")]
		public unsafe cef_x509cert_principal_t* GetIssuer()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_x509cert_principal_t*>)get_issuer)(self);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_serial_number;

		/// <summary>
		/// Returns the DER encoded serial number for the X.509 certificate. The value
		/// possibly includes a leading 00 byte.
		/// </summary>
		[NativeName("get_serial_number")]
		public unsafe cef_binary_value_t* GetSerialNumber()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_binary_value_t*>)get_serial_number)(self);
			}
		}

		/// <summary>
		/// cef_basetime_t (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_valid_start;

		/// <summary>
		/// Returns the date before which the X.509 certificate is invalid.
		/// CefBaseTime.GetTimeT() will return 0 if no date was specified.
		/// </summary>
		[NativeName("get_valid_start")]
		public unsafe cef_basetime_t GetValidStart()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_basetime_t>)get_valid_start)(self);
			}
		}

		/// <summary>
		/// cef_basetime_t (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_valid_expiry;

		/// <summary>
		/// Returns the date after which the X.509 certificate is invalid.
		/// CefBaseTime.GetTimeT() will return 0 if no date was specified.
		/// </summary>
		[NativeName("get_valid_expiry")]
		public unsafe cef_basetime_t GetValidExpiry()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_basetime_t>)get_valid_expiry)(self);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_derencoded;

		/// <summary>
		/// Returns the DER encoded data for the X.509 certificate.
		/// </summary>
		[NativeName("get_derencoded")]
		public unsafe cef_binary_value_t* GetDEREncoded()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_binary_value_t*>)get_derencoded)(self);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_pemencoded;

		/// <summary>
		/// Returns the PEM encoded data for the X.509 certificate.
		/// </summary>
		[NativeName("get_pemencoded")]
		public unsafe cef_binary_value_t* GetPEMEncoded()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, cef_binary_value_t*>)get_pemencoded)(self);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_x509certificate_t* self)*
		/// </summary>
		public void* get_issuer_chain_size;

		/// <summary>
		/// Returns the number of certificates in the issuer chain. If 0, the
		/// certificate is self-signed.
		/// </summary>
		[NativeName("get_issuer_chain_size")]
		public unsafe UIntPtr GetIssuerChainSize()
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, UIntPtr>)get_issuer_chain_size)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_x509certificate_t* self, size_t* chainCount, _cef_binary_value_t** chain)*
		/// </summary>
		public void* get_derencoded_issuer_chain;

		/// <summary>
		/// Returns the DER encoded data for the certificate issuer chain. If we failed
		/// to encode a certificate in the chain it is still present in the array but
		/// is an NULL string.
		/// </summary>
		[NativeName("get_derencoded_issuer_chain")]
		public unsafe void GetDEREncodedIssuerChain(UIntPtr* chainCount, cef_binary_value_t** chain)
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, UIntPtr*, cef_binary_value_t**, void>)get_derencoded_issuer_chain)(self, chainCount, chain);
			}
		}

		/// <summary>
		/// void (*)(_cef_x509certificate_t* self, size_t* chainCount, _cef_binary_value_t** chain)*
		/// </summary>
		public void* get_pemencoded_issuer_chain;

		/// <summary>
		/// Returns the PEM encoded data for the certificate issuer chain. If we failed
		/// to encode a certificate in the chain it is still present in the array but
		/// is an NULL string.
		/// </summary>
		[NativeName("get_pemencoded_issuer_chain")]
		public unsafe void GetPEMEncodedIssuerChain(UIntPtr* chainCount, cef_binary_value_t** chain)
		{
			fixed (cef_x509certificate_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_x509certificate_t*, UIntPtr*, cef_binary_value_t**, void>)get_pemencoded_issuer_chain)(self, chainCount, chain);
			}
		}
	}
}

