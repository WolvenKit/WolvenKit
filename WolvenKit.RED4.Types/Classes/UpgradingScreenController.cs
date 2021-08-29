using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpgradingScreenController : CraftingMainLogicController
	{
		private CArray<CWeakHandle<AGenericTooltipController>> _itemTooltipControllers;
		private CArray<CHandle<InventoryTooltipData>> _tooltipDatas;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private CHandle<gameItemData> _newItem;
		private CHandle<gameStatModifierData_Deprecated> _statMod;
		private CHandle<gameStatModifierData_Deprecated> _levelMod;

		[Ordinal(39)] 
		[RED("itemTooltipControllers")] 
		public CArray<CWeakHandle<AGenericTooltipController>> ItemTooltipControllers
		{
			get => GetProperty(ref _itemTooltipControllers);
			set => SetProperty(ref _itemTooltipControllers, value);
		}

		[Ordinal(40)] 
		[RED("tooltipDatas")] 
		public CArray<CHandle<InventoryTooltipData>> TooltipDatas
		{
			get => GetProperty(ref _tooltipDatas);
			set => SetProperty(ref _tooltipDatas, value);
		}

		[Ordinal(41)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetProperty(ref _weaponAreas);
			set => SetProperty(ref _weaponAreas, value);
		}

		[Ordinal(42)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(43)] 
		[RED("newItem")] 
		public CHandle<gameItemData> NewItem
		{
			get => GetProperty(ref _newItem);
			set => SetProperty(ref _newItem, value);
		}

		[Ordinal(44)] 
		[RED("statMod")] 
		public CHandle<gameStatModifierData_Deprecated> StatMod
		{
			get => GetProperty(ref _statMod);
			set => SetProperty(ref _statMod, value);
		}

		[Ordinal(45)] 
		[RED("levelMod")] 
		public CHandle<gameStatModifierData_Deprecated> LevelMod
		{
			get => GetProperty(ref _levelMod);
			set => SetProperty(ref _levelMod, value);
		}
	}
}
