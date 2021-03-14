using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayClickEvent : redEvent
	{
		private InventoryItemData _itemData;
		private CHandle<inkActionName> _actionName;
		private CEnum<gameItemDisplayContext> _displayContext;
		private CBool _isBuybackStack;
		private CHandle<inkPointerEvent> _evt;

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
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CHandle<inkActionName>) CR2WTypeManager.Create("handle:inkActionName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get
			{
				if (_displayContext == null)
				{
					_displayContext = (CEnum<gameItemDisplayContext>) CR2WTypeManager.Create("gameItemDisplayContext", "displayContext", cr2w, this);
				}
				return _displayContext;
			}
			set
			{
				if (_displayContext == value)
				{
					return;
				}
				_displayContext = value;
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

		[Ordinal(4)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get
			{
				if (_evt == null)
				{
					_evt = (CHandle<inkPointerEvent>) CR2WTypeManager.Create("handle:inkPointerEvent", "evt", cr2w, this);
				}
				return _evt;
			}
			set
			{
				if (_evt == value)
				{
					return;
				}
				_evt = value;
				PropertySet(this);
			}
		}

		public ItemDisplayClickEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
