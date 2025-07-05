using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponHandlingSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("equipEvent")] 
		public CName EquipEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("unequipStartedEvent")] 
		public CName UnequipStartedEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("unequippedEvent")] 
		public CName UnequippedEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioWeaponHandlingSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
