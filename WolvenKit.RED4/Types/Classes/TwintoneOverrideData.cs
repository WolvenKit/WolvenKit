using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneOverrideData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(8)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TwintoneOverrideData()
		{
			Template = new VehicleVisualCustomizationTemplate();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
