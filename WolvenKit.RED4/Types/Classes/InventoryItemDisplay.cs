using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemDisplay : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("RarityRoot")] 
		public inkWidgetReference RarityRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("ModsRoot")] 
		public inkCompoundWidgetReference ModsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("RarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("IconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("IconShadowImage")] 
		public inkImageWidgetReference IconShadowImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("IconFallback")] 
		public inkImageWidgetReference IconFallback
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("BackgroundShape")] 
		public inkImageWidgetReference BackgroundShape
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("BackgroundHighlight")] 
		public inkImageWidgetReference BackgroundHighlight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("BackgroundFrame")] 
		public inkImageWidgetReference BackgroundFrame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("QuantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("ModName")] 
		public CName ModName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("toggleHighlight")] 
		public inkWidgetReference ToggleHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("equippedIcon")] 
		public inkWidgetReference EquippedIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("DefaultCategoryIconName")] 
		public CString DefaultCategoryIconName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("ItemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(20)] 
		[RED("AttachementsDisplay")] 
		public CArray<CWeakHandle<InventoryItemAttachmentDisplay>> AttachementsDisplay
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryItemAttachmentDisplay>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryItemAttachmentDisplay>>>(value);
		}

		[Ordinal(21)] 
		[RED("smallSize")] 
		public Vector2 SmallSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("bigSize")] 
		public Vector2 BigSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(23)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public InventoryItemDisplay()
		{
			RarityRoot = new inkWidgetReference();
			ModsRoot = new inkCompoundWidgetReference();
			RarityWrapper = new inkWidgetReference();
			IconImage = new inkImageWidgetReference();
			IconShadowImage = new inkImageWidgetReference();
			IconFallback = new inkImageWidgetReference();
			BackgroundShape = new inkImageWidgetReference();
			BackgroundHighlight = new inkImageWidgetReference();
			BackgroundFrame = new inkImageWidgetReference();
			QuantityText = new inkTextWidgetReference();
			ToggleHighlight = new inkWidgetReference();
			EquippedIcon = new inkWidgetReference();
			DefaultCategoryIconName = "undefined";
			ItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			AttachementsDisplay = new();
			SmallSize = new Vector2();
			BigSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
