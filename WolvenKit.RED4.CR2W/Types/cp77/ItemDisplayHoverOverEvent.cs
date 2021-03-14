using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoverOverEvent : redEvent
	{
		private InventoryItemData _itemData;
		private wCHandle<InventoryItemDisplayController> _display;
		private wCHandle<inkWidget> _widget;
		private CBool _isBuybackStack;

		[Ordinal(0)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("display")] 
		public wCHandle<InventoryItemDisplayController> Display
		{
			get
			{
				if (_display == null)
				{
					_display = (wCHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("whandle:InventoryItemDisplayController", "display", cr2w, this);
				}
				return _display;
			}
			set
			{
				if (_display == value)
				{
					return;
				}
				_display = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get
			{
				if (_isBuybackStack == null)
				{
					_isBuybackStack = (CBool) CR2WTypeManager.Create("Bool", "isBuybackStack", cr2w, this);
				}
				return _isBuybackStack;
			}
			set
			{
				if (_isBuybackStack == value)
				{
					return;
				}
				_isBuybackStack = value;
				PropertySet(this);
			}
		}

		public ItemDisplayHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
