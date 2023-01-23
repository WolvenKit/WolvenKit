using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpgradingScreenController : CraftingMainLogicController
	{
		[Ordinal(39)] 
		[RED("itemTooltipControllers")] 
		public CArray<CWeakHandle<AGenericTooltipController>> ItemTooltipControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<AGenericTooltipController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<AGenericTooltipController>>>(value);
		}

		[Ordinal(40)] 
		[RED("tooltipDatas")] 
		public CArray<CHandle<InventoryTooltipData>> TooltipDatas
		{
			get => GetPropertyValue<CArray<CHandle<InventoryTooltipData>>>();
			set => SetPropertyValue<CArray<CHandle<InventoryTooltipData>>>(value);
		}

		[Ordinal(41)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(42)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataEquipmentArea>>>(value);
		}

		[Ordinal(43)] 
		[RED("newItem")] 
		public CWeakHandle<gameItemData> NewItem
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(44)] 
		[RED("statMod")] 
		public CHandle<gameStatModifierData_Deprecated> StatMod
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(45)] 
		[RED("levelMod")] 
		public CHandle<gameStatModifierData_Deprecated> LevelMod
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public UpgradingScreenController()
		{
			MaxIngredientCount = 8;
			ItemTooltipControllers = new();
			TooltipDatas = new();
			WeaponAreas = new();
			EquipAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
