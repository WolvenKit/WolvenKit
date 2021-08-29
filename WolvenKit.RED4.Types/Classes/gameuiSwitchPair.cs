using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSwitchPair : RedBaseClass
	{
		private CWeakHandle<gameuiCharacterCustomizationOption> _prevOption;
		private CWeakHandle<gameuiCharacterCustomizationOption> _currOption;

		[Ordinal(0)] 
		[RED("prevOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> PrevOption
		{
			get => GetProperty(ref _prevOption);
			set => SetProperty(ref _prevOption, value);
		}

		[Ordinal(1)] 
		[RED("currOption")] 
		public CWeakHandle<gameuiCharacterCustomizationOption> CurrOption
		{
			get => GetProperty(ref _currOption);
			set => SetProperty(ref _currOption, value);
		}
	}
}
