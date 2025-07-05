using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TwintoneOverrideData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("templateType")] 
		public CEnum<VehicleVisualCustomizationType> TemplateType
		{
			get => GetPropertyValue<CEnum<VehicleVisualCustomizationType>>();
			set => SetPropertyValue<CEnum<VehicleVisualCustomizationType>>(value);
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
