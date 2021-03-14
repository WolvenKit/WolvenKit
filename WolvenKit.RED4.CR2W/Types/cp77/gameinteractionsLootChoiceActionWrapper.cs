using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLootChoiceActionWrapper : CVariable
	{
		private CBool _removeItem;
		private gameItemID _itemId;
		private CName _action;

		[Ordinal(0)] 
		[RED("removeItem")] 
		public CBool RemoveItem
		{
			get
			{
				if (_removeItem == null)
				{
					_removeItem = (CBool) CR2WTypeManager.Create("Bool", "removeItem", cr2w, this);
				}
				return _removeItem;
			}
			set
			{
				if (_removeItem == value)
				{
					return;
				}
				_removeItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CName Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CName) CR2WTypeManager.Create("CName", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public gameinteractionsLootChoiceActionWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
