using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDisplay : BaseButtonView
	{
		private inkWidgetReference _rarityRoot;
		private inkCompoundWidgetReference _modsRoot;
		private inkWidgetReference _rarityWrapper;
		private inkImageWidgetReference _iconImage;
		private inkImageWidgetReference _iconShadowImage;
		private inkImageWidgetReference _iconFallback;
		private inkImageWidgetReference _backgroundShape;
		private inkImageWidgetReference _backgroundHighlight;
		private inkImageWidgetReference _backgroundFrame;
		private inkTextWidgetReference _quantityText;
		private CName _modName;
		private inkWidgetReference _toggleHighlight;
		private inkWidgetReference _equippedIcon;
		private CString _defaultCategoryIconName;
		private InventoryItemData _itemData;
		private CArray<CWeakHandle<InventoryItemAttachmentDisplay>> _attachementsDisplay;
		private Vector2 _smallSize;
		private Vector2 _bigSize;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(2)] 
		[RED("RarityRoot")] 
		public inkWidgetReference RarityRoot
		{
			get => GetProperty(ref _rarityRoot);
			set => SetProperty(ref _rarityRoot, value);
		}

		[Ordinal(3)] 
		[RED("ModsRoot")] 
		public inkCompoundWidgetReference ModsRoot
		{
			get => GetProperty(ref _modsRoot);
			set => SetProperty(ref _modsRoot, value);
		}

		[Ordinal(4)] 
		[RED("RarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetProperty(ref _rarityWrapper);
			set => SetProperty(ref _rarityWrapper, value);
		}

		[Ordinal(5)] 
		[RED("IconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetProperty(ref _iconImage);
			set => SetProperty(ref _iconImage, value);
		}

		[Ordinal(6)] 
		[RED("IconShadowImage")] 
		public inkImageWidgetReference IconShadowImage
		{
			get => GetProperty(ref _iconShadowImage);
			set => SetProperty(ref _iconShadowImage, value);
		}

		[Ordinal(7)] 
		[RED("IconFallback")] 
		public inkImageWidgetReference IconFallback
		{
			get => GetProperty(ref _iconFallback);
			set => SetProperty(ref _iconFallback, value);
		}

		[Ordinal(8)] 
		[RED("BackgroundShape")] 
		public inkImageWidgetReference BackgroundShape
		{
			get => GetProperty(ref _backgroundShape);
			set => SetProperty(ref _backgroundShape, value);
		}

		[Ordinal(9)] 
		[RED("BackgroundHighlight")] 
		public inkImageWidgetReference BackgroundHighlight
		{
			get => GetProperty(ref _backgroundHighlight);
			set => SetProperty(ref _backgroundHighlight, value);
		}

		[Ordinal(10)] 
		[RED("BackgroundFrame")] 
		public inkImageWidgetReference BackgroundFrame
		{
			get => GetProperty(ref _backgroundFrame);
			set => SetProperty(ref _backgroundFrame, value);
		}

		[Ordinal(11)] 
		[RED("QuantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetProperty(ref _quantityText);
			set => SetProperty(ref _quantityText, value);
		}

		[Ordinal(12)] 
		[RED("ModName")] 
		public CName ModName
		{
			get => GetProperty(ref _modName);
			set => SetProperty(ref _modName, value);
		}

		[Ordinal(13)] 
		[RED("toggleHighlight")] 
		public inkWidgetReference ToggleHighlight
		{
			get => GetProperty(ref _toggleHighlight);
			set => SetProperty(ref _toggleHighlight, value);
		}

		[Ordinal(14)] 
		[RED("equippedIcon")] 
		public inkWidgetReference EquippedIcon
		{
			get => GetProperty(ref _equippedIcon);
			set => SetProperty(ref _equippedIcon, value);
		}

		[Ordinal(15)] 
		[RED("DefaultCategoryIconName")] 
		public CString DefaultCategoryIconName
		{
			get => GetProperty(ref _defaultCategoryIconName);
			set => SetProperty(ref _defaultCategoryIconName, value);
		}

		[Ordinal(16)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(17)] 
		[RED("AttachementsDisplay")] 
		public CArray<CWeakHandle<InventoryItemAttachmentDisplay>> AttachementsDisplay
		{
			get => GetProperty(ref _attachementsDisplay);
			set => SetProperty(ref _attachementsDisplay, value);
		}

		[Ordinal(18)] 
		[RED("smallSize")] 
		public Vector2 SmallSize
		{
			get => GetProperty(ref _smallSize);
			set => SetProperty(ref _smallSize, value);
		}

		[Ordinal(19)] 
		[RED("bigSize")] 
		public Vector2 BigSize
		{
			get => GetProperty(ref _bigSize);
			set => SetProperty(ref _bigSize, value);
		}

		[Ordinal(20)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public InventoryItemDisplay()
		{
			_defaultCategoryIconName = new() { Text = "undefined" };
		}
	}
}
