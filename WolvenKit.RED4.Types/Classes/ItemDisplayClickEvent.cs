using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemDisplayClickEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		[Ordinal(2)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(3)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		public ItemDisplayClickEvent()
		{
			ItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
		}
	}
}
