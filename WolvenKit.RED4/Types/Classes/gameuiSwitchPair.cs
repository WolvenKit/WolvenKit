using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSwitchPair : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prevOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> PrevOption
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>(value);
		}

		[Ordinal(1)] 
		[RED("currOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> CurrOption
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterCustomizationOption>>(value);
		}

		public gameuiSwitchPair()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
