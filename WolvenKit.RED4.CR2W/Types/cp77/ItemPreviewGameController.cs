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
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get
			{
				if (_itemLevelText == null)
				{
					_itemLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemLevelText", cr2w, this);
				}
				return _itemLevelText;
			}
			set
			{
				if (_itemLevelText == value)
				{
					return;
				}
				_itemLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get
			{
				if (_itemRarityWidget == null)
				{
					_itemRarityWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRarityWidget", cr2w, this);
				}
				return _itemRarityWidget;
			}
			set
			{
				if (_itemRarityWidget == value)
				{
					return;
				}
				_itemRarityWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<InventoryItemPreviewData>) CR2WTypeManager.Create("handle:InventoryItemPreviewData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get
			{
				if (_isMouseDown == null)
				{
					_isMouseDown = (CBool) CR2WTypeManager.Create("Bool", "isMouseDown", cr2w, this);
				}
				return _isMouseDown;
			}
			set
			{
				if (_isMouseDown == value)
				{
					return;
				}
				_isMouseDown = value;
				PropertySet(this);
			}
		}

		public ItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
