//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.12.2
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "headerControls"
	/// <summary>Header Controls</summary>
	public partial interface IHeaderControls : IPublishedContent
	{
		/// <summary>Header Color</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		string HeaderColor { get; }

		/// <summary>Header Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent HeaderImage { get; }

		/// <summary>Header Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		string HeaderText { get; }
	}

	/// <summary>Header Controls</summary>
	[PublishedModel("headerControls")]
	public partial class HeaderControls : PublishedContentModel, IHeaderControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const string ModelTypeAlias = "headerControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeaderControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HeaderControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Header Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("headerColor")]
		public string HeaderColor => GetHeaderColor(this);

		/// <summary>Static getter for Header Color</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static string GetHeaderColor(IHeaderControls that) => that.Value<string>("headerColor");

		///<summary>
		/// Header Image: Please select the header image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("headerImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent HeaderImage => GetHeaderImage(this);

		/// <summary>Static getter for Header Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetHeaderImage(IHeaderControls that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("headerImage");

		///<summary>
		/// Header Text: Please enter the text to be displayed on the header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("headerText")]
		public string HeaderText => GetHeaderText(this);

		/// <summary>Static getter for Header Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static string GetHeaderText(IHeaderControls that) => that.Value<string>("headerText");
	}
}
