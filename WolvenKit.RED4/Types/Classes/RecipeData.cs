using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RecipeData : IScriptable
	{
		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("ingredients")] 
		public CArray<IngredientData> Ingredients
		{
			get => GetPropertyValue<CArray<IngredientData>>();
			set => SetPropertyValue<CArray<IngredientData>>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CString Type
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get => GetPropertyValue<CHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryItem")] 
		public gameInventoryItemData InventoryItem
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(9)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		public RecipeData()
		{
			Ingredients = new();
			InventoryItem = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
