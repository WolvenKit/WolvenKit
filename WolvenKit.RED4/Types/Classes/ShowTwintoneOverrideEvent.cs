using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShowTwintoneOverrideEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("templateType")] 
		public CEnum<VehicleVisualCustomizationType> TemplateType
		{
			get => GetPropertyValue<CEnum<VehicleVisualCustomizationType>>();
			set => SetPropertyValue<CEnum<VehicleVisualCustomizationType>>(value);
		}

		[Ordinal(1)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ShowTwintoneOverrideEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
