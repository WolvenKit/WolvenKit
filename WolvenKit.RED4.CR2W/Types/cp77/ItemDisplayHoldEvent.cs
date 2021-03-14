using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoldEvent : redEvent
	{
		private InventoryItemData _itemData;
		private CHandle<inkActionName> _actionName;

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

		public ItemDisplayHoldEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
