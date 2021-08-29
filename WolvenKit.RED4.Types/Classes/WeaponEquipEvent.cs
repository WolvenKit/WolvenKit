using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponEquipEvent : redEvent
	{
		private CHandle<AnimFeature_EquipType> _animFeature;
		private CWeakHandle<gameItemObject> _item;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_EquipType> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(1)] 
		[RED("item")] 
		public CWeakHandle<gameItemObject> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}
	}
}
