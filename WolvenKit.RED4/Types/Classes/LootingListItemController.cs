using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootingListItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("iconicLines")] 
		public inkWidgetReference IconicLines
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemQuantity")] 
		public inkTextWidgetReference ItemQuantity
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("defaultIcon")] 
		public inkWidgetReference DefaultIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("specialIcon")] 
		public inkImageWidgetReference SpecialIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("comparisionArrow")] 
		public inkImageWidgetReference ComparisionArrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemTypeIconWrapper")] 
		public inkWidgetReference ItemTypeIconWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemTypeIcon")] 
		public inkImageWidgetReference ItemTypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(13)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get => GetPropertyValue<CHandle<MinimalLootingListItemData>>();
			set => SetPropertyValue<CHandle<MinimalLootingListItemData>>(value);
		}

		public LootingListItemController()
		{
			WidgetWrapper = new inkWidgetReference();
			ItemName = new inkTextWidgetReference();
			ItemRarity = new inkWidgetReference();
			IconicLines = new inkWidgetReference();
			ItemQuantity = new inkTextWidgetReference();
			DefaultIcon = new inkWidgetReference();
			SpecialIcon = new inkImageWidgetReference();
			ComparisionArrow = new inkImageWidgetReference();
			ItemTypeIconWrapper = new inkWidgetReference();
			ItemTypeIcon = new inkImageWidgetReference();
			HighlightFrames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
