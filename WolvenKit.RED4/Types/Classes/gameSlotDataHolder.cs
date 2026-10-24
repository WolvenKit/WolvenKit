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
		[RED("rightWeapon")] 
		public gameSlotWeaponData RightWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(2)] 
		[RED("leftWeapon")] 
		public gameSlotWeaponData LeftWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		public gameSlotDataHolder()
		{
			AmmoData = new();
			RightWeapon = new gameSlotWeaponData();
			LeftWeapon = new gameSlotWeaponData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
