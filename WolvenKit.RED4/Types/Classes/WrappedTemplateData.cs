using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WrappedTemplateData : IScriptable
	{
		[Ordinal(0)] 
		[RED("parentGridController")] 
		public CWeakHandle<TwintoneTemplateGridController> ParentGridController
		{
			get => GetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>();
			set => SetPropertyValue<CWeakHandle<TwintoneTemplateGridController>>(value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(2)] 
		[RED("indexInList")] 
		public CUInt32 IndexInList
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("canAcceptSave")] 
		public CBool CanAcceptSave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WrappedTemplateData()
		{
			Template = new VehicleVisualCustomizationTemplate();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
