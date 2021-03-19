using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DpadWheelItemController : inkWidgetLogicController
	{
		private inkWidgetReference _selectorWrapper;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _displayWrapper;
		private inkWidgetReference _itemWrapper;
		private inkWidgetReference _arrows;
		private inkImageWidgetReference _abilityIcon;
		private inkImageWidgetReference _quickHackIcon;
		private inkImageWidgetReference _highlight02;
		private inkImageWidgetReference _highlight03;
		private inkImageWidgetReference _highlight04;
		private inkImageWidgetReference _highlight05;
		private inkImageWidgetReference _highlight06;
		private inkImageWidgetReference _highlight07;
		private inkImageWidgetReference _highlight08;
		private CFloat _textDist;
		private CFloat _weaponTextDist;
		private QuickSlotCommand _data;
		private CHandle<inkWidget> _root;
		private CHandle<InventoryItemDisplay> _item;
		private CHandle<inkWidget> _itemWidget;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private inkImageWidgetReference _highlight;
		private InventoryItemData _itemData;
		private AbilityData _abilityData;
		private CName _quickHackWheelDefIcon;

		[Ordinal(1)] 
		[RED("selectorWrapper")] 
		public inkWidgetReference SelectorWrapper
		{
			get => GetProperty(ref _selectorWrapper);
			set => SetProperty(ref _selectorWrapper, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("displayWrapper")] 
		public inkWidgetReference DisplayWrapper
		{
			get => GetProperty(ref _displayWrapper);
			set => SetProperty(ref _displayWrapper, value);
		}

		[Ordinal(4)] 
		[RED("itemWrapper")] 
		public inkWidgetReference ItemWrapper
		{
			get => GetProperty(ref _itemWrapper);
			set => SetProperty(ref _itemWrapper, value);
		}

		[Ordinal(5)] 
		[RED("arrows")] 
		public inkWidgetReference Arrows
		{
			get => GetProperty(ref _arrows);
			set => SetProperty(ref _arrows, value);
		}

		[Ordinal(6)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetProperty(ref _abilityIcon);
			set => SetProperty(ref _abilityIcon, value);
		}

		[Ordinal(7)] 
		[RED("quickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get => GetProperty(ref _quickHackIcon);
			set => SetProperty(ref _quickHackIcon, value);
		}

		[Ordinal(8)] 
		[RED("highlight02")] 
		public inkImageWidgetReference Highlight02
		{
			get => GetProperty(ref _highlight02);
			set => SetProperty(ref _highlight02, value);
		}

		[Ordinal(9)] 
		[RED("highlight03")] 
		public inkImageWidgetReference Highlight03
		{
			get => GetProperty(ref _highlight03);
			set => SetProperty(ref _highlight03, value);
		}

		[Ordinal(10)] 
		[RED("highlight04")] 
		public inkImageWidgetReference Highlight04
		{
			get => GetProperty(ref _highlight04);
			set => SetProperty(ref _highlight04, value);
		}

		[Ordinal(11)] 
		[RED("highlight05")] 
		public inkImageWidgetReference Highlight05
		{
			get => GetProperty(ref _highlight05);
			set => SetProperty(ref _highlight05, value);
		}

		[Ordinal(12)] 
		[RED("highlight06")] 
		public inkImageWidgetReference Highlight06
		{
			get => GetProperty(ref _highlight06);
			set => SetProperty(ref _highlight06, value);
		}

		[Ordinal(13)] 
		[RED("highlight07")] 
		public inkImageWidgetReference Highlight07
		{
			get => GetProperty(ref _highlight07);
			set => SetProperty(ref _highlight07, value);
		}

		[Ordinal(14)] 
		[RED("highlight08")] 
		public inkImageWidgetReference Highlight08
		{
			get => GetProperty(ref _highlight08);
			set => SetProperty(ref _highlight08, value);
		}

		[Ordinal(15)] 
		[RED("textDist")] 
		public CFloat TextDist
		{
			get => GetProperty(ref _textDist);
			set => SetProperty(ref _textDist, value);
		}

		[Ordinal(16)] 
		[RED("weaponTextDist")] 
		public CFloat WeaponTextDist
		{
			get => GetProperty(ref _weaponTextDist);
			set => SetProperty(ref _weaponTextDist, value);
		}

		[Ordinal(17)] 
		[RED("data")] 
		public QuickSlotCommand Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(19)] 
		[RED("item")] 
		public CHandle<InventoryItemDisplay> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(20)] 
		[RED("itemWidget")] 
		public CHandle<inkWidget> ItemWidget
		{
			get => GetProperty(ref _itemWidget);
			set => SetProperty(ref _itemWidget, value);
		}

		[Ordinal(21)] 
		[RED("InventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(22)] 
		[RED("highlight")] 
		public inkImageWidgetReference Highlight
		{
			get => GetProperty(ref _highlight);
			set => SetProperty(ref _highlight, value);
		}

		[Ordinal(23)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(24)] 
		[RED("abilityData")] 
		public AbilityData AbilityData
		{
			get => GetProperty(ref _abilityData);
			set => SetProperty(ref _abilityData, value);
		}

		[Ordinal(25)] 
		[RED("quickHackWheelDefIcon")] 
		public CName QuickHackWheelDefIcon
		{
			get => GetProperty(ref _quickHackWheelDefIcon);
			set => SetProperty(ref _quickHackWheelDefIcon, value);
		}

		public DpadWheelItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
