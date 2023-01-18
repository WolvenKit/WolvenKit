using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		[Ordinal(11)] 
		[RED("colliderWidgetRef")] 
		public inkWidgetReference ColliderWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("colliderWidget")] 
		public CWeakHandle<inkWidget> ColliderWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(17)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("c_ITEM_ROTATION_SPEED")] 
		public CFloat C_ITEM_ROTATION_SPEED
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ItemPreviewGameController()
		{
			ColliderWidgetRef = new();
			ItemNameText = new();
			ItemLevelText = new();
			ItemRarityWidget = new();
			C_ITEM_ROTATION_SPEED = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
