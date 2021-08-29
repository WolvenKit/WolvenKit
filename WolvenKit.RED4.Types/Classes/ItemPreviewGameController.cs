using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemLevelText;
		private inkWidgetReference _itemRarityWidget;
		private CHandle<InventoryItemPreviewData> _data;
		private CBool _isMouseDown;

		[Ordinal(9)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(10)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetProperty(ref _itemLevelText);
			set => SetProperty(ref _itemLevelText, value);
		}

		[Ordinal(11)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetProperty(ref _itemRarityWidget);
			set => SetProperty(ref _itemRarityWidget, value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(13)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}
	}
}
