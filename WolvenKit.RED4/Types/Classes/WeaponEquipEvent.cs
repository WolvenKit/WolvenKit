using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponEquipEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_EquipType> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_EquipType>>();
			set => SetPropertyValue<CHandle<AnimFeature_EquipType>>(value);
		}

		[Ordinal(1)] 
		[RED("item")] 
		public CWeakHandle<gameItemObject> Item
		{
			get => GetPropertyValue<CWeakHandle<gameItemObject>>();
			set => SetPropertyValue<CWeakHandle<gameItemObject>>(value);
		}

		[Ordinal(2)] 
		[RED("isLeftWeapon")] 
		public CBool IsLeftWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeaponEquipEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
