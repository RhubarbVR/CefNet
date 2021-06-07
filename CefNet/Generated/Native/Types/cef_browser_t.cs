﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_browser_capi.h
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
	/// Structure used to represent a browser. When used in the browser process the
	/// functions of this structure may be called on any thread unless otherwise
	/// indicated in the comments. When used in the render process the functions of
	/// this structure may only be called on the main thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_browser_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// True if this object is currently valid. This will return false (0) after
		/// cef_life_span_handler_t::OnBeforeClose is called.
		/// </summary>
		[NativeName("is_valid")]
		public unsafe int IsValid()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)is_valid)(self);
			}
		}

		/// <summary>
		/// _cef_browser_host_t* (*)(_cef_browser_t* self)*
		/// </summary>
		public void* get_host;

		/// <summary>
		/// Returns the browser host object. This function can only be called in the
		/// browser process.
		/// </summary>
		[NativeName("get_host")]
		public unsafe cef_browser_host_t* GetHost()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_browser_host_t*>)get_host)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* can_go_back;

		/// <summary>
		/// Returns true (1) if the browser can navigate backwards.
		/// </summary>
		[NativeName("can_go_back")]
		public unsafe int CanGoBack()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)can_go_back)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self)*
		/// </summary>
		public void* go_back;

		/// <summary>
		/// Navigate backwards.
		/// </summary>
		[NativeName("go_back")]
		public unsafe void GoBack()
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, void>)go_back)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* can_go_forward;

		/// <summary>
		/// Returns true (1) if the browser can navigate forwards.
		/// </summary>
		[NativeName("can_go_forward")]
		public unsafe int CanGoForward()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)can_go_forward)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self)*
		/// </summary>
		public void* go_forward;

		/// <summary>
		/// Navigate forwards.
		/// </summary>
		[NativeName("go_forward")]
		public unsafe void GoForward()
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, void>)go_forward)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* is_loading;

		/// <summary>
		/// Returns true (1) if the browser is currently loading.
		/// </summary>
		[NativeName("is_loading")]
		public unsafe int IsLoading()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)is_loading)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self)*
		/// </summary>
		public void* reload;

		/// <summary>
		/// Reload the current page.
		/// </summary>
		[NativeName("reload")]
		public unsafe void Reload()
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, void>)reload)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self)*
		/// </summary>
		public void* reload_ignore_cache;

		/// <summary>
		/// Reload the current page ignoring any cached data.
		/// </summary>
		[NativeName("reload_ignore_cache")]
		public unsafe void ReloadIgnoreCache()
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, void>)reload_ignore_cache)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self)*
		/// </summary>
		public void* stop_load;

		/// <summary>
		/// Stop loading the page.
		/// </summary>
		[NativeName("stop_load")]
		public unsafe void StopLoad()
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, void>)stop_load)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* get_identifier;

		/// <summary>
		/// Returns the globally unique identifier for this browser. This value is also
		/// used as the tabId for extension APIs.
		/// </summary>
		[NativeName("get_identifier")]
		public unsafe int GetIdentifier()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)get_identifier)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self, _cef_browser_t* that)*
		/// </summary>
		public void* is_same;

		/// <summary>
		/// Returns true (1) if this object is pointing to the same handle as |that|
		/// object.
		/// </summary>
		[NativeName("is_same")]
		public unsafe int IsSame(cef_browser_t* that)
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_browser_t*, int>)is_same)(self, that);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* is_popup;

		/// <summary>
		/// Returns true (1) if the browser is a popup.
		/// </summary>
		[NativeName("is_popup")]
		public unsafe int IsPopup()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)is_popup)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_browser_t* self)*
		/// </summary>
		public void* has_document;

		/// <summary>
		/// Returns true (1) if a document has been loaded in the browser.
		/// </summary>
		[NativeName("has_document")]
		public unsafe int HasDocument()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, int>)has_document)(self);
			}
		}

		/// <summary>
		/// _cef_frame_t* (*)(_cef_browser_t* self)*
		/// </summary>
		public void* get_main_frame;

		/// <summary>
		/// Returns the main (top-level) frame for the browser. In the browser process
		/// this will return a valid object until after
		/// cef_life_span_handler_t::OnBeforeClose is called. In the renderer process
		/// this will return NULL if the main frame is hosted in a different renderer
		/// process (e.g. for cross-origin sub-frames). The main frame object will
		/// change during cross-origin navigation or re-navigation after renderer
		/// process termination (due to crashes, etc).
		/// </summary>
		[NativeName("get_main_frame")]
		public unsafe cef_frame_t* GetMainFrame()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_frame_t*>)get_main_frame)(self);
			}
		}

		/// <summary>
		/// _cef_frame_t* (*)(_cef_browser_t* self)*
		/// </summary>
		public void* get_focused_frame;

		/// <summary>
		/// Returns the focused frame for the browser.
		/// </summary>
		[NativeName("get_focused_frame")]
		public unsafe cef_frame_t* GetFocusedFrame()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_frame_t*>)get_focused_frame)(self);
			}
		}

		/// <summary>
		/// _cef_frame_t* (*)(_cef_browser_t* self, int64 identifier)*
		/// </summary>
		public void* get_frame_byident;

		/// <summary>
		/// Returns the frame with the specified identifier, or NULL if not found.
		/// </summary>
		[NativeName("get_frame_byident")]
		public unsafe cef_frame_t* GetFrameByIdent(long identifier)
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, long, cef_frame_t*>)get_frame_byident)(self, identifier);
			}
		}

		/// <summary>
		/// _cef_frame_t* (*)(_cef_browser_t* self, const cef_string_t* name)*
		/// </summary>
		public void* get_frame;

		/// <summary>
		/// Returns the frame with the specified name, or NULL if not found.
		/// </summary>
		[NativeName("get_frame")]
		public unsafe cef_frame_t* GetFrame([Immutable]cef_string_t* name)
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_string_t*, cef_frame_t*>)get_frame)(self, name);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_browser_t* self)*
		/// </summary>
		public void* get_frame_count;

		/// <summary>
		/// Returns the number of frames that currently exist.
		/// </summary>
		[NativeName("get_frame_count")]
		public unsafe UIntPtr GetFrameCount()
		{
			fixed (cef_browser_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_browser_t*, UIntPtr>)get_frame_count)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self, size_t* identifiersCount, int64* identifiers)*
		/// </summary>
		public void* get_frame_identifiers;

		/// <summary>
		/// Returns the identifiers of all existing frames.
		/// </summary>
		[NativeName("get_frame_identifiers")]
		public unsafe void GetFrameIdentifiers(UIntPtr* identifiersCount, long* identifiers)
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, UIntPtr*, long*, void>)get_frame_identifiers)(self, identifiersCount, identifiers);
			}
		}

		/// <summary>
		/// void (*)(_cef_browser_t* self, cef_string_list_t names)*
		/// </summary>
		public void* get_frame_names;

		/// <summary>
		/// Returns the names of all existing frames.
		/// </summary>
		[NativeName("get_frame_names")]
		public unsafe void GetFrameNames(cef_string_list_t names)
		{
			fixed (cef_browser_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_browser_t*, cef_string_list_t, void>)get_frame_names)(self, names);
			}
		}
	}
}

