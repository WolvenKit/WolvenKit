using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SPaperdollEquipData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("equipArea")] 
		public gameSEquipArea EquipArea
		{
			get => GetPropertyValue<gameSEquipArea>();
			set => SetPropertyValue<gameSEquipArea>(value);
		}

		[Ordinal(1)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SPaperdollEquipData()
		{
			EquipArea = new gameSEquipArea { AreaType = Enums.gamedataEquipmentArea.Invalid, EquipSlots = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
