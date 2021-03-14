using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaperDollSlotController : inkButtonDpadSupportedController
	{
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CInt32 _slotIndex;
		private CArray<CName> _areaTags;
		private gameItemID _itemID;
		private CString _slotName;
		private CHandle<gameItemData> _itemData;
		private CBool _locked;

		[Ordinal(26)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("areaTags")] 
		public CArray<CName> AreaTags
		{
			get
			{
				if (_areaTags == null)
				{
					_areaTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "areaTags", cr2w, this);
				}
				return _areaTags;
			}
			set
			{
				if (_areaTags == value)
				{
					return;
				}
				_areaTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CString) CR2WTypeManager.Create("String", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
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

		[Ordinal(32)] 
		[RED("locked")] 
		public CBool Locked
		{
			get
			{
				if (_locked == null)
				{
					_locked = (CBool) CR2WTypeManager.Create("Bool", "locked", cr2w, this);
				}
				return _locked;
			}
			set
			{
				if (_locked == value)
				{
					return;
				}
				_locked = value;
				PropertySet(this);
			}
		}

		public PaperDollSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
