using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnTwintoneOverrideClosedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(1)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public OnTwintoneOverrideClosedEvent()
		{
			Template = new VehicleVisualCustomizationTemplate();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
