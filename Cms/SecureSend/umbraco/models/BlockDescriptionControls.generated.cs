//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.4.3+192eb2699ba4131addbb08236f60eb031707f751
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "blockDescriptionControls"
	/// <summary>Block Description Controls</summary>
	public partial interface IBlockDescriptionControls : IPublishedElement
	{
		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Description { get; }
	}

	/// <summary>Block Description Controls</summary>
	[PublishedModel("blockDescriptionControls")]
	public partial class BlockDescriptionControls : PublishedElementModel, IBlockDescriptionControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		public new const string ModelTypeAlias = "blockDescriptionControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<BlockDescriptionControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public BlockDescriptionControls(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Description: Vul een descriptie in voor dit item
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description")]
		public virtual string Description => GetDescription(this, _publishedValueFallback);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.4.3+192eb2699ba4131addbb08236f60eb031707f751")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetDescription(IBlockDescriptionControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "description");
	}
}
