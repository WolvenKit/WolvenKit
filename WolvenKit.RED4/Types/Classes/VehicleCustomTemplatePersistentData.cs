using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleCustomTemplatePersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vehicleID")] 
		public TweakDBID VehicleID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public SavedVehicleVisualCustomizationTemplate Template
		{
			get => GetPropertyValue<SavedVehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<SavedVehicleVisualCustomizationTemplate>(value);
		}

		public VehicleCustomTemplatePersistentData()
		{
			Template = new SavedVehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
