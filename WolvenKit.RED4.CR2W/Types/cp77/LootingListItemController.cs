using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingListItemController : inkWidgetLogicController
	{
		private inkWidgetReference _widgetWrapper;
		private inkTextWidgetReference _itemName;
		private inkWidgetReference _itemRarity;
		private inkWidgetReference _iconicLines;
		private inkTextWidgetReference _itemQuantity;
		private inkWidgetReference _defaultIcon;
		private inkImageWidgetReference _specialIcon;
		private inkImageWidgetReference _comparisionArrow;
		private inkWidgetReference _itemTypeIconWrapper;
		private inkImageWidgetReference _itemTypeIcon;
		private CArray<inkWidgetReference> _highlightFrames;
		private CHandle<InventoryTooltipData> _tooltipData;
		private CHandle<MinimalLootingListItemData> _lootingData;

		[Ordinal(1)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetProperty(ref _widgetWrapper);
			set => SetProperty(ref _widgetWrapper, value);
		}

		[Ordinal(2)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(3)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetProperty(ref _itemRarity);
			set => SetProperty(ref _itemRarity, value);
		}

		[Ordinal(4)] 
		[RED("iconicLines")] 
		public inkWidgetReference IconicLines
		{
			get => GetProperty(ref _iconicLines);
			set => SetProperty(ref _iconicLines, value);
		}

		[Ordinal(5)] 
		[RED("itemQuantity")] 
		public inkTextWidgetReference ItemQuantity
		{
			get => GetProperty(ref _itemQuantity);
			set => SetProperty(ref _itemQuantity, value);
		}

		[Ordinal(6)] 
		[RED("defaultIcon")] 
		public inkWidgetReference DefaultIcon
		{
			get => GetProperty(ref _defaultIcon);
			set => SetProperty(ref _defaultIcon, value);
		}

		[Ordinal(7)] 
		[RED("specialIcon")] 
		public inkImageWidgetReference SpecialIcon
		{
			get => GetProperty(ref _specialIcon);
			set => SetProperty(ref _specialIcon, value);
		}

		[Ordinal(8)] 
		[RED("comparisionArrow")] 
		public inkImageWidgetReference ComparisionArrow
		{
			get => GetProperty(ref _comparisionArrow);
			set => SetProperty(ref _comparisionArrow, value);
		}

		[Ordinal(9)] 
		[RED("itemTypeIconWrapper")] 
		public inkWidgetReference ItemTypeIconWrapper
		{
			get => GetProperty(ref _itemTypeIconWrapper);
			set => SetProperty(ref _itemTypeIconWrapper, value);
		}

		[Ordinal(10)] 
		[RED("itemTypeIcon")] 
		public inkImageWidgetReference ItemTypeIcon
		{
			get => GetProperty(ref _itemTypeIcon);
			set => SetProperty(ref _itemTypeIcon, value);
		}

		[Ordinal(11)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetProperty(ref _highlightFrames);
			set => SetProperty(ref _highlightFrames, value);
		}

		[Ordinal(12)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(13)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get => GetProperty(ref _lootingData);
			set => SetProperty(ref _lootingData, value);
		}

		public LootingListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
