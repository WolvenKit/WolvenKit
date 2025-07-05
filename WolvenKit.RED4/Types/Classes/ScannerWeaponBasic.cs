using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerWeaponBasic : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("weapon")] 
		public CName Weapon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ScannerWeaponBasic()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
