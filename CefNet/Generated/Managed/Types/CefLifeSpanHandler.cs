﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_life_span_handler_t.cs
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
	/// Implement this structure to handle events related to browser life span. The
	/// functions of this structure will be called on the UI thread unless otherwise
	/// indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefLifeSpanHandler : CefBaseRefCounted<cef_life_span_handler_t>, ICefLifeSpanHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnBeforePopupDelegate fnOnBeforePopup = OnBeforePopupImpl;

		private static readonly OnAfterCreatedDelegate fnOnAfterCreated = OnAfterCreatedImpl;

		private static readonly DoCloseDelegate fnDoClose = DoCloseImpl;

		private static readonly OnBeforeCloseDelegate fnOnBeforeClose = OnBeforeCloseImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefLifeSpanHandler Create(IntPtr instance)
		{
			return new CefLifeSpanHandler((cef_life_span_handler_t*)instance);
		}

		public CefLifeSpanHandler()
		{
			cef_life_span_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_before_popup = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforePopup);
			self->on_after_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnAfterCreated);
			self->do_close = (void*)Marshal.GetFunctionPointerForDelegate(fnDoClose);
			self->on_before_close = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeClose);
			#else
			self->on_before_popup = (delegate* unmanaged[Stdcall]<cef_life_span_handler_t*, cef_browser_t*, cef_frame_t*, cef_string_t*, cef_string_t*, CefWindowOpenDisposition, int, cef_popup_features_t*, cef_window_info_t*, cef_client_t**, cef_browser_settings_t*, cef_dictionary_value_t**, int*, int>)&OnBeforePopupImpl;
			self->on_after_created = (delegate* unmanaged[Stdcall]<cef_life_span_handler_t*, cef_browser_t*, void>)&OnAfterCreatedImpl;
			self->do_close = (delegate* unmanaged[Stdcall]<cef_life_span_handler_t*, cef_browser_t*, int>)&DoCloseImpl;
			self->on_before_close = (delegate* unmanaged[Stdcall]<cef_life_span_handler_t*, cef_browser_t*, void>)&OnBeforeCloseImpl;
			#endif
		}

		public CefLifeSpanHandler(cef_life_span_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefLifeSpanHandlerPrivate.AvoidOnBeforePopup();

		/// <summary>
		/// Called on the UI thread before a new popup browser is created. The
		/// |browser| and |frame| values represent the source of the popup request. The
		/// |target_url| and |target_frame_name| values indicate where the popup
		/// browser should navigate and may be NULL if not specified with the request.
		/// The |target_disposition| value indicates where the user intended to open
		/// the popup (e.g. current tab, new tab, etc). The |user_gesture| value will
		/// be true (1) if the popup was opened via explicit user gesture (e.g.
		/// clicking a link) or false (0) if the popup opened automatically (e.g. via
		/// the DomContentLoaded event). The |popupFeatures| structure contains
		/// additional information about the requested popup window. To allow creation
		/// of the popup browser optionally modify |windowInfo|, |client|, |settings|
		/// and |no_javascript_access| and return false (0). To cancel creation of the
		/// popup browser return true (1). The |client| and |settings| values will
		/// default to the source browser&apos;s values. If the |no_javascript_access| value
		/// is set to false (0) the new browser will not be scriptable and may not be
		/// hosted in the same renderer process as the source browser. Any
		/// modifications to |windowInfo| will be ignored if the parent browser is
		/// wrapped in a cef_browser_view_t. Popup browser creation will be canceled if
		/// the parent browser is destroyed before the popup browser creation completes
		/// (indicated by a call to OnAfterCreated for the popup browser). The
		/// |extra_info| parameter provides an opportunity to specify extra information
		/// specific to the created popup browser that will be passed to
		/// cef_render_process_handler_t::on_browser_created() in the render process.
		/// </summary>
		protected internal unsafe virtual bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref int noJavascriptAccess)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OnBeforePopupDelegate(cef_life_span_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, cef_string_t* target_frame_name, CefWindowOpenDisposition target_disposition, int user_gesture, cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, cef_dictionary_value_t** extra_info, int* no_javascript_access);

#endif // NET_LESS_5_0
		// int (*)(_cef_life_span_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, const cef_string_t* target_url, const cef_string_t* target_frame_name, cef_window_open_disposition_t target_disposition, int user_gesture, const const _cef_popup_features_t* popupFeatures, _cef_window_info_t* windowInfo, _cef_client_t** client, _cef_browser_settings_t* settings, _cef_dictionary_value_t** extra_info, int* no_javascript_access)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OnBeforePopupImpl(cef_life_span_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, cef_string_t* target_frame_name, CefWindowOpenDisposition target_disposition, int user_gesture, cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, cef_dictionary_value_t** extra_info, int* no_javascript_access)
		{
			var instance = GetInstance((IntPtr)self) as CefLifeSpanHandler;
			if (instance == null || ((ICefLifeSpanHandlerPrivate)instance).AvoidOnBeforePopup())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				return default;
			}
			CefClient obj_client = CefClient.Wrap(CefClient.Create, *client);
			CefDictionaryValue obj_extra_info = CefDictionaryValue.Wrap(CefDictionaryValue.Create, *extra_info);
			int rv = instance.OnBeforePopup(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefString.Read(target_url), CefString.Read(target_frame_name), target_disposition, user_gesture != 0, *(CefPopupFeatures*)popupFeatures, CefWindowInfo.Wrap(windowInfo), ref obj_client, new CefBrowserSettings(settings), ref obj_extra_info, ref *no_javascript_access) ? 1 : 0;
			*client = (obj_client != null) ? obj_client.GetNativeInstance() : null;
			*extra_info = (obj_extra_info != null) ? obj_extra_info.GetNativeInstance() : null;
			return rv;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefLifeSpanHandlerPrivate.AvoidOnAfterCreated();

		/// <summary>
		/// Called after a new browser is created. It is now safe to begin performing
		/// actions with |browser|. cef_frame_handler_t callbacks related to initial
		/// main frame creation will arrive before this callback. See
		/// cef_frame_handler_t documentation for additional usage information.
		/// </summary>
		protected internal unsafe virtual void OnAfterCreated(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnAfterCreatedDelegate(cef_life_span_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_life_span_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnAfterCreatedImpl(cef_life_span_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefLifeSpanHandler;
			if (instance == null || ((ICefLifeSpanHandlerPrivate)instance).AvoidOnAfterCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnAfterCreated(CefBrowser.Wrap(CefBrowser.Create, browser));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefLifeSpanHandlerPrivate.AvoidDoClose();

		/// <summary>
		/// Called when a browser has recieved a request to close. This may result
		/// directly from a call to cef_browser_host_t::*close_browser() or indirectly
		/// if the browser is parented to a top-level window created by CEF and the
		/// user attempts to close that window (by clicking the &apos;X&apos;, for example). The
		/// do_close() function will be called after the JavaScript &apos;onunload&apos; event
		/// has been fired.
		/// An application should handle top-level owner window close notifications by
		/// calling cef_browser_host_t::try_close_browser() or
		/// cef_browser_host_t::CloseBrowser(false (0)) instead of allowing the window
		/// to close immediately (see the examples below). This gives CEF an
		/// opportunity to process the &apos;onbeforeunload&apos; event and optionally cancel the
		/// close before do_close() is called.
		/// When windowed rendering is enabled CEF will internally create a window or
		/// view to host the browser. In that case returning false (0) from do_close()
		/// will send the standard close notification to the browser&apos;s top-level owner
		/// window (e.g. WM_CLOSE on Windows, performClose: on OS X, &quot;delete_event&quot; on
		/// Linux or cef_window_delegate_t::can_close() callback from Views). If the
		/// browser&apos;s host window/view has already been destroyed (via view hierarchy
		/// tear-down, for example) then do_close() will not be called for that browser
		/// since is no longer possible to cancel the close.
		/// When windowed rendering is disabled returning false (0) from do_close()
		/// will cause the browser object to be destroyed immediately.
		/// If the browser&apos;s top-level owner window requires a non-standard close
		/// notification then send that notification from do_close() and return true
		/// (1).
		/// The cef_life_span_handler_t::on_before_close() function will be called
		/// after do_close() (if do_close() is called) and immediately before the
		/// browser object is destroyed. The application should only exit after
		/// on_before_close() has been called for all existing browsers.
		/// The below examples describe what should happen during window close when the
		/// browser is parented to an application-provided top-level window.
		/// Example 1: Using cef_browser_host_t::try_close_browser(). This is
		/// recommended for clients using standard close handling and windows created
		/// on the browser process UI thread. 1.  User clicks the window close button
		/// which sends a close notification to
		/// the application&apos;s top-level window.
		/// 2.  Application&apos;s top-level window receives the close notification and
		/// calls TryCloseBrowser() (which internally calls CloseBrowser(false)).
		/// TryCloseBrowser() returns false so the client cancels the window close.
		/// 3.  JavaScript &apos;onbeforeunload&apos; handler executes and shows the close
		/// confirmation dialog (which can be overridden via
		/// CefJSDialogHandler::OnBeforeUnloadDialog()).
		/// 4.  User approves the close. 5.  JavaScript &apos;onunload&apos; handler executes. 6.
		/// CEF sends a close notification to the application&apos;s top-level window
		/// (because DoClose() returned false by default).
		/// 7.  Application&apos;s top-level window receives the close notification and
		/// calls TryCloseBrowser(). TryCloseBrowser() returns true so the client
		/// allows the window close.
		/// 8.  Application&apos;s top-level window is destroyed. 9.  Application&apos;s
		/// on_before_close() handler is called and the browser object
		/// is destroyed.
		/// 10. Application exits by calling cef_quit_message_loop() if no other
		/// browsers
		/// exist.
		/// Example 2: Using cef_browser_host_t::CloseBrowser(false (0)) and
		/// implementing the do_close() callback. This is recommended for clients using
		/// non-standard close handling or windows that were not created on the browser
		/// process UI thread. 1.  User clicks the window close button which sends a
		/// close notification to
		/// the application&apos;s top-level window.
		/// 2.  Application&apos;s top-level window receives the close notification and:
		/// A. Calls CefBrowserHost::CloseBrowser(false).
		/// B. Cancels the window close.
		/// 3.  JavaScript &apos;onbeforeunload&apos; handler executes and shows the close
		/// confirmation dialog (which can be overridden via
		/// CefJSDialogHandler::OnBeforeUnloadDialog()).
		/// 4.  User approves the close. 5.  JavaScript &apos;onunload&apos; handler executes. 6.
		/// Application&apos;s do_close() handler is called. Application will:
		/// A. Set a flag to indicate that the next close attempt will be allowed.
		/// B. Return false.
		/// 7.  CEF sends an close notification to the application&apos;s top-level window.
		/// 8.  Application&apos;s top-level window receives the close notification and
		/// allows the window to close based on the flag from #6B.
		/// 9.  Application&apos;s top-level window is destroyed. 10. Application&apos;s
		/// on_before_close() handler is called and the browser object
		/// is destroyed.
		/// 11. Application exits by calling cef_quit_message_loop() if no other
		/// browsers
		/// exist.
		/// </summary>
		protected internal unsafe virtual bool DoClose(CefBrowser browser)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int DoCloseDelegate(cef_life_span_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// int (*)(_cef_life_span_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int DoCloseImpl(cef_life_span_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefLifeSpanHandler;
			if (instance == null || ((ICefLifeSpanHandlerPrivate)instance).AvoidDoClose())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return default;
			}
			return instance.DoClose(CefBrowser.Wrap(CefBrowser.Create, browser)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefLifeSpanHandlerPrivate.AvoidOnBeforeClose();

		/// <summary>
		/// Called just before a browser is destroyed. Release all references to the
		/// browser object and do not attempt to execute any functions on the browser
		/// object (other than IsValid, GetIdentifier or IsSame) after this callback
		/// returns. cef_frame_handler_t callbacks related to final main frame
		/// destruction will arrive after this callback and cef_browser_t::IsValid will
		/// return false (0) at that time. Any in-progress network requests associated
		/// with |browser| will be aborted when the browser is destroyed, and
		/// cef_resource_request_handler_t callbacks related to those requests may
		/// still arrive on the IO thread after this callback. See cef_frame_handler_t
		/// and do_close() documentation for additional usage information.
		/// </summary>
		protected internal unsafe virtual void OnBeforeClose(CefBrowser browser)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBeforeCloseDelegate(cef_life_span_handler_t* self, cef_browser_t* browser);

#endif // NET_LESS_5_0
		// void (*)(_cef_life_span_handler_t* self, _cef_browser_t* browser)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnBeforeCloseImpl(cef_life_span_handler_t* self, cef_browser_t* browser)
		{
			var instance = GetInstance((IntPtr)self) as CefLifeSpanHandler;
			if (instance == null || ((ICefLifeSpanHandlerPrivate)instance).AvoidOnBeforeClose())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				return;
			}
			instance.OnBeforeClose(CefBrowser.Wrap(CefBrowser.Create, browser));
		}
	}
}
