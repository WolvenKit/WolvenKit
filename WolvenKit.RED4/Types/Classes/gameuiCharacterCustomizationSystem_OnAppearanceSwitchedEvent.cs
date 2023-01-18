using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("pairs")] 
		public CArray<gameuiSwitchPair> Pairs
		{
			get => GetPropertyValue<CArray<gameuiSwitchPair>>();
			set => SetPropertyValue<CArray<gameuiSwitchPair>>(value);
		}

		public gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent()
		{
			Pairs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
