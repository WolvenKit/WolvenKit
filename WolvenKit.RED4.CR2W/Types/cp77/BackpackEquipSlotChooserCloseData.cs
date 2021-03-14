using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private InventoryItemData _itemData;
		private CInt32 _slotIndex;

		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get
			{
				if (_confirm == null)
				{
					_confirm = (CBool) CR2WTypeManager.Create("Bool", "confirm", cr2w, this);
				}
				return _confirm;
			}
			set
			{
				if (_confirm == value)
				{
					return;
				}
				_confirm = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		public BackpackEquipSlotChooserCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
