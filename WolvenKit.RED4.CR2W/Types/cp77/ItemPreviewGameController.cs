using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemLevelText;
		private inkWidgetReference _itemRarityWidget;
		private CHandle<InventoryItemPreviewData> _data;
		private CBool _isMouseDown;

		[Ordinal(8)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(9)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetProperty(ref _itemLevelText);
			set => SetProperty(ref _itemLevelText, value);
		}

		[Ordinal(10)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetProperty(ref _itemRarityWidget);
			set => SetProperty(ref _itemRarityWidget, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}

		public ItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
