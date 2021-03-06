﻿// <copyright file="IBrowser.cs">
//    Copyright © 2013 Dan Piessens  All rights reserved.
// </copyright>

namespace SpecBind.BrowserSupport
{
	using System;
	using System.Collections.Generic;

	using SpecBind.Pages;

	/// <summary>
	/// An interface to describe browser methods.
	/// </summary>
	public interface IBrowser
	{
		/// <summary>
		/// Gets the type of the base page.
		/// </summary>
		/// <value>
		/// The type of the base page.
		/// </value>
		Type BasePageType { get; }

		/// <summary>
		/// Closes this instance.
		/// </summary>
		void Close();

        /// <summary>
        /// Dismisses the alert.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="text">The text to enter.</param>
	    void DismissAlert(AlertBoxAction action, string text);

		/// <summary>
		/// Ensures the on page.
		/// </summary>
		/// <param name="page">The page.</param>
		/// <exception cref="PageNavigationException">Thrown if the page is not on the current page.</exception>
		void EnsureOnPage(IPage page);

		/// <summary>
		/// Gets the URI for the page if supported by the browser.
		/// </summary>
		/// <param name="pageType">Type of the page.</param>
		/// <returns>The URI partial string if found.</returns>
		string GetUriForPageType(Type pageType);

		/// <summary>
		/// Navigates the browser to the given <paramref name="url"/>.
		/// </summary>
		/// <param name="url">The URL specified as a well formed Uri.</param>
		void GoTo(Uri url);

		/// <summary>
		/// Navigates to the specified URL defined by the page.
		/// </summary>
		/// <param name="pageType">Type of the page.</param>
		/// <param name="parameters">The parameters to fill it in.</param>
		/// <returns>The page object when navigated to.</returns>
		IPage GoToPage(Type pageType, IDictionary<string, string> parameters);

		/// <summary>
		/// Gets the page instance from the browser.
		/// </summary>
		/// <param name="pageType">Type of the page.</param>
		/// <returns>
		/// The page object.
		/// </returns>
		IPage Page(Type pageType);

        /// <summary>
        /// Takes the screenshot from the native browser.
        /// </summary>
        /// <param name="imageFolder">The image folder.</param>
        /// <param name="fileNameBase">The file name base.</param>
        /// <returns>The full path of the image file.</returns>
	    string TakeScreenshot(string imageFolder, string fileNameBase);

        /// <summary>
        /// Executes the script.
        /// </summary>
        /// <param name="script">The script to execute.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>The result of the script if needed.</returns>
	    object ExecuteScript(string script, params object[] args);
	}
}