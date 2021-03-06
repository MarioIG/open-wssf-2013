﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MEF = global::System.ComponentModel.Composition;
using Modeling = global::Microsoft.VisualStudio.Modeling;
using ModelingExtEnablement = global::Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using DiagramsExtEnablement = global::Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;

namespace Microsoft.Practices.ServiceFactory.DataContracts.ExtensionEnablement
{
	/// <summary>
	/// Provides an extension filter string that can be used by all behavioural extension registrars generated for this designer.
	/// </summary>
	/// <remarks>For internal use within this Designer</remarks>
	public sealed class DataContractDslExtensionFilter
	{
		public const string MefMetadataFilter = "DataContractDslExtensionFilter";
	}

	/// <summary>
	/// Provides a strongly typed custom attribute which allows user to use the following: 
	///     [DataContractDslGestureExtension]
	/// in lieu of
	///		[Export(typeof(IGestureExtension)]
	///		[ExportMetadata("DataContractDslExtensionFilter", null)] 
	///
	/// Use this attribute to Export an IGestureExtension MEF part for DataContractDsl designer.
	/// </summary>
	[MEF::MetadataAttribute]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple=false)]
	public sealed class DataContractDslGestureExtensionAttribute : MEF::ExportAttribute
	{
		public DataContractDslGestureExtensionAttribute() : base(typeof(DiagramsExtEnablement.IGestureExtension))
		{
		}
		
		/// <summary>
		/// MEF metadata exported by this part.
		/// 
		/// The Property name is the key which indicates the base designer to which this extension belongs.
		/// </summary>
		public object DataContractDslExtensionFilter
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get { return null; }
		}
	}
	
	/// <summary>
	/// Provides a strongly typed custom attribute which allows user to use the following: 
	///     [DataContractDslCommandExtension]
	/// in lieu of
	///		[Export(typeof(ICommandExtension)]
	///		[ExportMetadata("DataContractDslExtensionFilter", null)] 
	///
	/// Use this attribute to Export an ICommandExtension MEF part for DataContractDsl designer.
	/// </summary>
	[MEF::MetadataAttribute]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple=false)]
	public sealed class DataContractDslCommandExtensionAttribute : MEF::ExportAttribute
	{
		public DataContractDslCommandExtensionAttribute() : base(typeof(ModelingExtEnablement.ICommandExtension))
		{
		}
		
		/// <summary>
		/// MEF metadata exported by this part.
		/// 
		/// The Property name is the key which indicates the base designer to which this extension belongs.
		/// </summary>
		public object DataContractDslExtensionFilter
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get { return null; }
		}
	}
	
	/// <summary>
	/// Provides a strongly typed custom attribute which allows user to use the following: 
	///     [DataContractDslValidationExtension]
	/// in lieu of
	///		[Export(typeof(typeof(Action<ValidationContext, object>))]
	///		[ExportMetadata("DataContractDslExtensionFilter", null)]
	///
	/// Use this attribute to Export a ValidationExtension MEF part for DataContractDsl designer.
	/// </summary>
	[MEF::MetadataAttribute]
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple=false)]
	public sealed class DataContractDslValidationExtensionAttribute : MEF::ExportAttribute
	{
		public DataContractDslValidationExtensionAttribute() : base(typeof(global::System.Action<Modeling::Validation.ValidationContext, object>))
		{
		}
		
		/// <summary>
		/// MEF metadata exported by this part.
		/// 
		/// The Property name is the key which indicates the base designer to which this extension belongs.
		/// </summary>
		public object DataContractDslExtensionFilter
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get { return null; }
		}
	}	
}