using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCrowdSettingsNameVehicleExpressionDefinition : AIbehaviorVehicleExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("settingsName")] 
		public CName SettingsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIbehaviorCrowdSettingsNameVehicleExpressionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
