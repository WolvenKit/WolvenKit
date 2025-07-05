using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrowdSettingsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CrowdSettingsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
