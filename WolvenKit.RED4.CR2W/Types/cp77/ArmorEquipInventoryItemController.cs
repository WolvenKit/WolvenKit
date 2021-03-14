using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipInventoryItemController : inkButtonDpadSupportedController
	{
		private gameItemID _itemID;
		private CHandle<gameItemData> _itemData;
		private CBool _empty;

		[Ordinal(26)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "itemData", cr2w, this);
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

		[Ordinal(28)] 
		[RED("empty")] 
		public CBool Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		public ArmorEquipInventoryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
