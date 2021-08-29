using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSlotDataHolder : IScriptable
	{
		private CArray<gameAmmoData> _ammoData;
		private gameSlotWeaponData _weapon;

		[Ordinal(0)] 
		[RED("ammoData")] 
		public CArray<gameAmmoData> AmmoData
		{
			get => GetProperty(ref _ammoData);
			set => SetProperty(ref _ammoData, value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public gameSlotWeaponData Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}
	}
}
