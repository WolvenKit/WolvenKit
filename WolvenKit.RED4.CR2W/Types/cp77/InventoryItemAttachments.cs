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
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(2)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(3)] 
		[RED("SlotType")] 
		public CEnum<gameInventoryItemAttachmentType> SlotType
		{
			get => GetProperty(ref _slotType);
			set => SetProperty(ref _slotType, value);
		}

		public InventoryItemAttachments(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
