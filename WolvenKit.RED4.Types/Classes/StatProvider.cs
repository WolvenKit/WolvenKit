using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatProvider : IScriptable
	{
		[Ordinal(0)] 
		[RED("GameItemData")] 
		public CWeakHandle<gameItemData> GameItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(1)] 
		[RED("PartData")] 
		public gameInnerItemData PartData
		{
			get => GetPropertyValue<gameInnerItemData>();
			set => SetPropertyValue<gameInnerItemData>(value);
		}

		[Ordinal(2)] 
		[RED("InventoryItemData")] 
		public gameInventoryItemData InventoryItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(3)] 
		[RED("dataSource")] 
		public CEnum<gameEStatProviderDataSource> DataSource
		{
			get => GetPropertyValue<CEnum<gameEStatProviderDataSource>>();
			set => SetPropertyValue<CEnum<gameEStatProviderDataSource>>(value);
		}

		public StatProvider()
		{
			PartData = new();
			InventoryItemData = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			DataSource = Enums.gameEStatProviderDataSource.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
