using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		[Ordinal(10)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(14)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("c_ITEM_ROTATION_SPEED")] 
		public CFloat C_ITEM_ROTATION_SPEED
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ItemPreviewGameController()
		{
			ItemNameText = new();
			ItemLevelText = new();
			ItemRarityWidget = new();
			C_ITEM_ROTATION_SPEED = 4.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
