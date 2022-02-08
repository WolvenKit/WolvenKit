using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
	}
}
