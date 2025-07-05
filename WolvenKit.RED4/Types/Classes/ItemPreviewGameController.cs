using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		[Ordinal(12)] 
		[RED("colliderWidgetRef")] 
		public inkWidgetReference ColliderWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("colliderWidget")] 
		public CWeakHandle<inkWidget> ColliderWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("itemDescriptionText")] 
		public inkTextWidgetReference ItemDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("perkLine")] 
		public inkWidgetReference PerkLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("typeLine")] 
		public inkWidgetReference TypeLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("typeText")] 
		public inkTextWidgetReference TypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}

		[Ordinal(25)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("c_ITEM_ROTATION_SPEED")] 
		public CFloat C_ITEM_ROTATION_SPEED
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ItemPreviewGameController()
		{
			ColliderWidgetRef = new inkWidgetReference();
			ItemNameText = new inkTextWidgetReference();
			ItemDescriptionText = new inkTextWidgetReference();
			PerkLine = new inkWidgetReference();
			PerkIcon = new inkImageWidgetReference();
			PerkText = new inkTextWidgetReference();
			TypeLine = new inkWidgetReference();
			TypeIcon = new inkImageWidgetReference();
			TypeText = new inkTextWidgetReference();
			ItemLevelText = new inkTextWidgetReference();
			ItemRarityWidget = new inkWidgetReference();
			C_ITEM_ROTATION_SPEED = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
