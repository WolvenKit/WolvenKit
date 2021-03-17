using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSPartSlots : CVariable
	{
		private CEnum<gameESlotState> _status;
		private gameItemID _installedPart;
		private TweakDBID _slotID;
		private gameInnerItemData _innerItemData;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameESlotState> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get => GetProperty(ref _installedPart);
			set => SetProperty(ref _installedPart, value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(3)] 
		[RED("innerItemData")] 
		public gameInnerItemData InnerItemData
		{
			get => GetProperty(ref _innerItemData);
			set => SetProperty(ref _innerItemData, value);
		}

		public gameSPartSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
