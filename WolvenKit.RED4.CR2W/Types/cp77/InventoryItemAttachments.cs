using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachments : CVariable
	{
		private TweakDBID _slotID;
		private InventoryItemData _itemData;
		private CString _slotName;
		private CEnum<gameInventoryItemAttachmentType> _slotType;

		[Ordinal(0)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "SlotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "ItemData", cr2w, this);
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

		[Ordinal(2)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CString) CR2WTypeManager.Create("String", "SlotName", cr2w, this);
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

		[Ordinal(3)] 
		[RED("SlotType")] 
		public CEnum<gameInventoryItemAttachmentType> SlotType
		{
			get
			{
				if (_slotType == null)
				{
					_slotType = (CEnum<gameInventoryItemAttachmentType>) CR2WTypeManager.Create("gameInventoryItemAttachmentType", "SlotType", cr2w, this);
				}
				return _slotType;
			}
			set
			{
				if (_slotType == value)
				{
					return;
				}
				_slotType = value;
				PropertySet(this);
			}
		}

		public InventoryItemAttachments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
