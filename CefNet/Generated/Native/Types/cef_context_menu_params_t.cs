﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_context_menu_handler_capi.h
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
	/// Provides information about the context menu state. The ethods of this
	/// structure can only be accessed on browser process the UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_context_menu_params_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_xcoord;

		/// <summary>
		/// Returns the X coordinate of the mouse where the context menu was invoked.
		/// Coords are relative to the associated RenderView&apos;s origin.
		/// </summary>
		[NativeName("get_xcoord")]
		public unsafe int GetXCoord()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)get_xcoord)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_ycoord;

		/// <summary>
		/// Returns the Y coordinate of the mouse where the context menu was invoked.
		/// Coords are relative to the associated RenderView&apos;s origin.
		/// </summary>
		[NativeName("get_ycoord")]
		public unsafe int GetYCoord()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)get_ycoord)(self);
			}
		}

		/// <summary>
		/// cef_context_menu_type_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_type_flags;

		/// <summary>
		/// Returns flags representing the type of node that the context menu was
		/// invoked on.
		/// </summary>
		[NativeName("get_type_flags")]
		public unsafe CefContextMenuTypeFlags GetTypeFlags()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, CefContextMenuTypeFlags>)get_type_flags)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_link_url;

		/// <summary>
		/// Returns the URL of the link, if any, that encloses the node that the
		/// context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_link_url")]
		public unsafe cef_string_userfree_t GetLinkUrl()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_link_url)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_unfiltered_link_url;

		/// <summary>
		/// Returns the link URL, if any, to be used ONLY for &quot;copy link address&quot;. We
		/// don&apos;t validate this field in the frontend process.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_unfiltered_link_url")]
		public unsafe cef_string_userfree_t GetUnfilteredLinkUrl()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_unfiltered_link_url)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_source_url;

		/// <summary>
		/// Returns the source URL, if any, for the element that the context menu was
		/// invoked on. Example of elements with source URLs are img, audio, and video.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_source_url")]
		public unsafe cef_string_userfree_t GetSourceUrl()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_source_url)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* has_image_contents;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an image which has non-
		/// NULL contents.
		/// </summary>
		[NativeName("has_image_contents")]
		public unsafe int HasImageContents()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)has_image_contents)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_title_text;

		/// <summary>
		/// Returns the title text or the alt text if the context menu was invoked on
		/// an image.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_title_text")]
		public unsafe cef_string_userfree_t GetTitleText()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_title_text)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_page_url;

		/// <summary>
		/// Returns the URL of the top level page that the context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_page_url")]
		public unsafe cef_string_userfree_t GetPageUrl()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_page_url)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_frame_url;

		/// <summary>
		/// Returns the URL of the subframe that the context menu was invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_frame_url")]
		public unsafe cef_string_userfree_t GetFrameUrl()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_frame_url)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_frame_charset;

		/// <summary>
		/// Returns the character encoding of the subframe that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_frame_charset")]
		public unsafe cef_string_userfree_t GetFrameCharset()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_frame_charset)(self);
			}
		}

		/// <summary>
		/// cef_context_menu_media_type_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_media_type;

		/// <summary>
		/// Returns the type of context node that the context menu was invoked on.
		/// </summary>
		[NativeName("get_media_type")]
		public unsafe CefContextMenuMediaType GetMediaType()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, CefContextMenuMediaType>)get_media_type)(self);
			}
		}

		/// <summary>
		/// cef_context_menu_media_state_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_media_state_flags;

		/// <summary>
		/// Returns flags representing the actions supported by the media element, if
		/// any, that the context menu was invoked on.
		/// </summary>
		[NativeName("get_media_state_flags")]
		public unsafe CefContextMenuMediaStateFlags GetMediaStateFlags()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, CefContextMenuMediaStateFlags>)get_media_state_flags)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_selection_text;

		/// <summary>
		/// Returns the text of the selection, if any, that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_selection_text")]
		public unsafe cef_string_userfree_t GetSelectionText()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_selection_text)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_misspelled_word;

		/// <summary>
		/// Returns the text of the misspelled word, if any, that the context menu was
		/// invoked on.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_misspelled_word")]
		public unsafe cef_string_userfree_t GetMisspelledWord()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_userfree_t>)get_misspelled_word)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self, cef_string_list_t suggestions)*
		/// </summary>
		public void* get_dictionary_suggestions;

		/// <summary>
		/// Returns true (1) if suggestions exist, false (0) otherwise. Fills in
		/// |suggestions| from the spell check service for the misspelled word if there
		/// is one.
		/// </summary>
		[NativeName("get_dictionary_suggestions")]
		public unsafe int GetDictionarySuggestions(cef_string_list_t suggestions)
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, cef_string_list_t, int>)get_dictionary_suggestions)(self, suggestions);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_editable;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an editable node.
		/// </summary>
		[NativeName("is_editable")]
		public unsafe int IsEditable()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)is_editable)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_spell_check_enabled;

		/// <summary>
		/// Returns true (1) if the context menu was invoked on an editable node where
		/// spell-check is enabled.
		/// </summary>
		[NativeName("is_spell_check_enabled")]
		public unsafe int IsSpellCheckEnabled()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)is_spell_check_enabled)(self);
			}
		}

		/// <summary>
		/// cef_context_menu_edit_state_flags_t (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* get_edit_state_flags;

		/// <summary>
		/// Returns flags representing the actions supported by the editable node, if
		/// any, that the context menu was invoked on.
		/// </summary>
		[NativeName("get_edit_state_flags")]
		public unsafe CefContextMenuEditStateFlags GetEditStateFlags()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, CefContextMenuEditStateFlags>)get_edit_state_flags)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_context_menu_params_t* self)*
		/// </summary>
		public void* is_custom_menu;

		/// <summary>
		/// Returns true (1) if the context menu contains items specified by the
		/// renderer process.
		/// </summary>
		[NativeName("is_custom_menu")]
		public unsafe int IsCustomMenu()
		{
			fixed (cef_context_menu_params_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_context_menu_params_t*, int>)is_custom_menu)(self);
			}
		}
	}
}

