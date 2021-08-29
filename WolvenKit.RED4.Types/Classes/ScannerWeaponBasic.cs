using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerWeaponBasic : ScannerChunk
	{
		private CName _weapon;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CName Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}
	}
}
