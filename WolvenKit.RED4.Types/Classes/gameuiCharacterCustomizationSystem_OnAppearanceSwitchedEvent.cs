using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent : redEvent
	{
		private CArray<gameuiSwitchPair> _pairs;

		[Ordinal(0)] 
		[RED("pairs")] 
		public CArray<gameuiSwitchPair> Pairs
		{
			get => GetProperty(ref _pairs);
			set => SetProperty(ref _pairs, value);
		}
	}
}
