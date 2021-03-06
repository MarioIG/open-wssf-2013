﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslIntegration = global::Microsoft.VisualStudio.Modeling.Integration;
using DslIntegrationShell = Microsoft.VisualStudio.Modeling.Integration.Shell;

namespace Microsoft.Practices.ServiceFactory.ServiceContracts.ModelBusAdapters
{
   /// <summary>
    /// Modelbus adapter generated class for a ServiceContractDsl model
    /// </summary>
    public partial class ServiceContractDslAdapterBase : DslIntegration::StandardModelingAdapter, DslIntegration::IModelingAdapterWithStore, DslIntegration::IModelingAdapterWithRootedModel
    {
        // Id of this logical adapter type
        public const string AdapterId = "Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractDslAdapter";

		#region Constructor(s)
        /// <summary>
        /// Constructor from a ModelBusReference, the adapter manager, and the root model element of the ServiceContractDsl model
        /// </summary>
        public ServiceContractDslAdapterBase(DslIntegration::ModelBusReference reference, DslIntegrationShell::VsModelingAdapterManager adapterManager, global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractModel rootModelElement)
            : base(reference, adapterManager, rootModelElement)
        {
		}
		#endregion

        /// <summary>
        /// Label by which the model will be displayed (for instance in the modelbus reference picker UI)
        /// </summary>
        public override string DisplayName
        {
            get { return global::System.IO.Path.GetFileNameWithoutExtension(this.DocumentHandler.ModelFile); }
        }

        /// <summary>
        /// Get the modelbus refrences of all the model elements of a given Type
        /// </summary>
        /// <param name="dataContract">Type of interest</param>
        /// <returns>Collection of modelbus refrences on all the instances of this type</returns>
        protected override global::System.Collections.Generic.IEnumerable<DslIntegration::ModelBusReference> GetElementReferences(global::System.Type dataContract)
        {
            if (dataContract == null)
            {
                throw new global::System.ArgumentNullException("dataContract");
            }

            global::System.Collections.ObjectModel.ReadOnlyCollection<DslModeling::ModelElement> mels = null;
            if (ModelRoot != null)
            {
                DslModeling::Store store = ModelRoot.Store;
                mels = this.ModelRoot.Store.ElementDirectory.FindElements(this.ModelRoot.Store.DomainDataDirectory.GetDomainClass(dataContract), true);
                if (mels != null)
                    foreach (DslModeling::ModelElement mel in mels)
                        yield return this.GetElementReference(mel);
            }
        }

        /// <summary>
        /// Get a view of the given reference
        /// </summary>
        /// <param name="reference">Refernce on the view we want to get</param>
        /// <returns>A ModelBusView of the given reference</returns>
        public override DslIntegration::ModelBusView GetView(DslIntegration::ModelBusReference reference)
        {
            return new DslIntegrationShell::StandardVsModelingDiagramView(this, reference);
        }

		public global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractModel ModelRoot
		{
			get { return base.AdapterModelRoot as global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractModel; }
		}

		public Microsoft.VisualStudio.Modeling.Store Store
		{
			get { return this.AdapterStore; }
		}

		Microsoft.VisualStudio.Modeling.ModelElement DslIntegration::IModelingAdapterWithRootedModel.ModelRoot
		{
			get { return AdapterModelRoot; }
		}
	}


	/// <summary>
	/// Modelbus adapter for a ServiceContractDsl model
	/// </summary>
	public partial class ServiceContractDslAdapter : ServiceContractDslAdapterBase
	{
		#region Constructor(s)
		/// <summary>
		/// Constructor from a ModelBusReference, the adapter manager, and the root model element of the ServiceContractDsl model
		/// </summary>
			public ServiceContractDslAdapter(DslIntegration::ModelBusReference reference, DslIntegrationShell::VsModelingAdapterManager adapterManager, global::Microsoft.Practices.ServiceFactory.ServiceContracts.ServiceContractModel rootModelElement)
				: base(reference, adapterManager, rootModelElement)
			{
			}
		#endregion
	}
}
