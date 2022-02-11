﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_sslstatus_t.cs
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
	/// Structure representing the SSL information for a navigation entry.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefSSLStatus : CefBaseRefCounted<cef_sslstatus_t>
	{
		internal static unsafe CefSSLStatus Create(IntPtr instance)
		{
			return new CefSSLStatus((cef_sslstatus_t*)instance);
		}

		public CefSSLStatus(cef_sslstatus_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether the status is related to a secure SSL/TLS connection.
		/// </summary>
		public unsafe virtual bool IsSecureConnection
		{
			get
			{
				return SafeCall(NativeInstance->IsSecureConnection() != 0);
			}
		}

		/// <summary>
		/// Gets a bitmask containing any and all problems verifying the server
		/// certificate.
		/// </summary>
		public unsafe virtual CefCertStatus CertStatus
		{
			get
			{
				return SafeCall(NativeInstance->GetCertStatus());
			}
		}

		/// <summary>
		/// Gets the SSL version used for the SSL connection.
		/// </summary>
		public unsafe virtual CefSSLVersion SSLVersion
		{
			get
			{
				return SafeCall(NativeInstance->GetSSLVersion());
			}
		}

		/// <summary>
		/// Gets a bitmask containing the page security content status.
		/// </summary>
		public unsafe virtual CefSSLContentStatus ContentStatus
		{
			get
			{
				return SafeCall(NativeInstance->GetContentStatus());
			}
		}

		/// <summary>
		/// Gets the X.509 certificate.
		/// </summary>
		public unsafe virtual CefX509Certificate X509Certificate
		{
			get
			{
				return SafeCall(CefX509Certificate.Wrap(CefX509Certificate.Create, NativeInstance->GetX509Certificate()));
			}
		}
	}
}
