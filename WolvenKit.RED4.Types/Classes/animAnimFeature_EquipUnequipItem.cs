using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_EquipUnequipItem : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("stateTransitionDuration")] 
		public CFloat StateTransitionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("itemState")] 
		public CInt32 ItemState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CInt32 ItemType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("firstEquip")] 
		public CBool FirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimFeature_EquipUnequipItem()
		{
			ItemType = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
