using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSlotDataHolder : IScriptable
	{
		[Ordinal(0)] 
		[RED("ammoData")] 
		public CArray<gameAmmoData> AmmoData
		{
			get => GetPropertyValue<CArray<gameAmmoData>>();
			set => SetPropertyValue<CArray<gameAmmoData>>(value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public gameSlotWeaponData Weapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		public gameSlotDataHolder()
		{
			AmmoData = new();
			Weapon = new() { WeaponID = new(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
