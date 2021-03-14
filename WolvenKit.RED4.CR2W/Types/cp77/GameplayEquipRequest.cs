using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayEquipRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CInt32 _slotIndex;
		private CBool _addToInventory;
		private CBool _equipToCurrentActiveSlot;
		private CBool _blockUpdateWeaponActiveSlots;
		private CBool _forceEquipWeapon;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("addToInventory")] 
		public CBool AddToInventory
		{
			get
			{
				if (_addToInventory == null)
				{
					_addToInventory = (CBool) CR2WTypeManager.Create("Bool", "addToInventory", cr2w, this);
				}
				return _addToInventory;
			}
			set
			{
				if (_addToInventory == value)
				{
					return;
				}
				_addToInventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("equipToCurrentActiveSlot")] 
		public CBool EquipToCurrentActiveSlot
		{
			get
			{
				if (_equipToCurrentActiveSlot == null)
				{
					_equipToCurrentActiveSlot = (CBool) CR2WTypeManager.Create("Bool", "equipToCurrentActiveSlot", cr2w, this);
				}
				return _equipToCurrentActiveSlot;
			}
			set
			{
				if (_equipToCurrentActiveSlot == value)
				{
					return;
				}
				_equipToCurrentActiveSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blockUpdateWeaponActiveSlots")] 
		public CBool BlockUpdateWeaponActiveSlots
		{
			get
			{
				if (_blockUpdateWeaponActiveSlots == null)
				{
					_blockUpdateWeaponActiveSlots = (CBool) CR2WTypeManager.Create("Bool", "blockUpdateWeaponActiveSlots", cr2w, this);
				}
				return _blockUpdateWeaponActiveSlots;
			}
			set
			{
				if (_blockUpdateWeaponActiveSlots == value)
				{
					return;
				}
				_blockUpdateWeaponActiveSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceEquipWeapon")] 
		public CBool ForceEquipWeapon
		{
			get
			{
				if (_forceEquipWeapon == null)
				{
					_forceEquipWeapon = (CBool) CR2WTypeManager.Create("Bool", "forceEquipWeapon", cr2w, this);
				}
				return _forceEquipWeapon;
			}
			set
			{
				if (_forceEquipWeapon == value)
				{
					return;
				}
				_forceEquipWeapon = value;
				PropertySet(this);
			}
		}

		public GameplayEquipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
