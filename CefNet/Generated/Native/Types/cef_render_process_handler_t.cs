﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_render_process_handler_capi.h
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
	/// Structure used to implement render process callbacks. The functions of this
	/// structure will be called on the render process main thread (TID_RENDERER)
	/// unless otherwise indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_render_process_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self)*
		/// </summary>
		public void* on_web_kit_initialized;

		/// <summary>
		/// Called after WebKit has been initialized.
		/// </summary>
		[NativeName("on_web_kit_initialized")]
		public unsafe void OnWebKitInitialized()
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, void>)on_web_kit_initialized)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_dictionary_value_t* extra_info)*
		/// </summary>
		public void* on_browser_created;

		/// <summary>
		/// Called after a browser has been created. When browsing cross-origin a new
		/// browser will be created before the old browser with the same identifier is
		/// destroyed. |extra_info| is an optional read-only value originating from
		/// cef_browser_host_t::cef_browser_host_create_browser(),
		/// cef_browser_host_t::cef_browser_host_create_browser_sync(),
		/// cef_life_span_handler_t::on_before_popup() or
		/// cef_browser_view_t::cef_browser_view_create().
		/// </summary>
		[NativeName("on_browser_created")]
		public unsafe void OnBrowserCreated(cef_browser_t* browser, cef_dictionary_value_t* extra_info)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_dictionary_value_t*, void>)on_browser_created)(self, browser, extra_info);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_browser_destroyed;

		/// <summary>
		/// Called before a browser is destroyed.
		/// </summary>
		[NativeName("on_browser_destroyed")]
		public unsafe void OnBrowserDestroyed(cef_browser_t* browser)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, void>)on_browser_destroyed)(self, browser);
			}
		}

		/// <summary>
		/// _cef_load_handler_t* (*)(_cef_render_process_handler_t* self)*
		/// </summary>
		public void* get_load_handler;

		/// <summary>
		/// Return the handler for browser load status events.
		/// </summary>
		[NativeName("get_load_handler")]
		public unsafe cef_load_handler_t* GetLoadHandler()
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_load_handler_t*>)get_load_handler)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context)*
		/// </summary>
		public void* on_context_created;

		/// <summary>
		/// Called immediately after the V8 context for a frame has been created. To
		/// retrieve the JavaScript &apos;window&apos; object use the
		/// cef_v8context_t::get_global() function. V8 handles can only be accessed
		/// from the thread on which they are created. A task runner for posting tasks
		/// on the associated thread can be retrieved via the
		/// cef_v8context_t::get_task_runner() function.
		/// </summary>
		[NativeName("on_context_created")]
		public unsafe void OnContextCreated(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, void>)on_context_created)(self, browser, frame, context);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context)*
		/// </summary>
		public void* on_context_released;

		/// <summary>
		/// Called immediately before the V8 context for a frame is released. No
		/// references to the context should be kept after this function is called.
		/// </summary>
		[NativeName("on_context_released")]
		public unsafe void OnContextReleased(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, void>)on_context_released)(self, browser, frame, context);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_v8context_t* context, _cef_v8exception_t* exception, _cef_v8stack_trace_t* stackTrace)*
		/// </summary>
		public void* on_uncaught_exception;

		/// <summary>
		/// Called for global uncaught exceptions in a frame. Execution of this
		/// callback is disabled by default. To enable set
		/// CefSettings.uncaught_exception_stack_size &gt; 0.
		/// </summary>
		[NativeName("on_uncaught_exception")]
		public unsafe void OnUncaughtException(cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, cef_v8exception_t*, cef_v8stack_trace_t*, void>)on_uncaught_exception)(self, browser, frame, context, exception, stackTrace);
			}
		}

		/// <summary>
		/// void (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_domnode_t* node)*
		/// </summary>
		public void* on_focused_node_changed;

		/// <summary>
		/// Called when a new node in the the browser gets focus. The |node| value may
		/// be NULL if no specific node has gained focus. The node object passed to
		/// this function represents a snapshot of the DOM at the time this function is
		/// executed. DOM objects are only valid for the scope of this function. Do not
		/// keep references to or attempt to access any DOM objects outside the scope
		/// of this function.
		/// </summary>
		[NativeName("on_focused_node_changed")]
		public unsafe void OnFocusedNodeChanged(cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_domnode_t*, void>)on_focused_node_changed)(self, browser, frame, node);
			}
		}

		/// <summary>
		/// int (*)(_cef_render_process_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, cef_process_id_t source_process, _cef_process_message_t* message)*
		/// </summary>
		public void* on_process_message_received;

		/// <summary>
		/// Called when a new message is received from a different process. Return true
		/// (1) if the message was handled or false (0) otherwise. It is safe to keep a
		/// reference to |message| outside of this callback.
		/// </summary>
		[NativeName("on_process_message_received")]
		public unsafe int OnProcessMessageReceived(cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message)
		{
			fixed (cef_render_process_handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, CefProcessId, cef_process_message_t*, int>)on_process_message_received)(self, browser, frame, source_process, message);
			}
		}
	}
}

