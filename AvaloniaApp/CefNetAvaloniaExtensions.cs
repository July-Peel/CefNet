﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.VisualTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApp
{
	public static class CefNetAvaloniaExtensions
	{
		public static TabControl FindTabControl(this Control tab)
		{
			Control control = tab;
			while (control != null)
			{
				if (control is TabControl tabControl)
					return tabControl;
				control = control.Parent as Control;
			}
			return null;
		}

		/// <summary>
		/// Finds a Child of a given item in the visual tree. 
		/// </summary>
		/// <param name="parent">A direct parent of the queried item.</param>
		/// <typeparam name="T">The type of the queried item.</typeparam>
		/// <param name="childName">x:Name or Name of child. </param>
		/// <returns>The first parent item that matches the submitted type parameter. 
		/// If not matching item can be found, 
		/// a null parent is being returned.</returns>
		public static T FindChild<T>(this Visual parent, string childName)
			where T : Visual
		{
			// Confirm parent and childName are valid. 
			if (parent == null) return null;

			T foundChild = null;

			foreach(Visual child in parent.GetVisualChildren())
			{ 
				// If the child is not of the request child type child
				T childType = child as T;
				if (childType is null)
				{
					// recursively drill down the tree
					foundChild = FindChild<T>(child, childName);

					// If the child is found, break so we do not overwrite the found child. 
					if (foundChild != null) break;
				}
				else if (!string.IsNullOrEmpty(childName))
				{
					var frameworkElement = child as Visual;
					// If the child's name is set for search
					if (frameworkElement != null && frameworkElement.Name == childName)
					{
						// if the child's name is of the request name
						foundChild = (T)child;
						break;
					}
				}
				else
				{
					// child element found.
					foundChild = (T)child;
					break;
				}
			}

			return foundChild;
		}

	}
}
