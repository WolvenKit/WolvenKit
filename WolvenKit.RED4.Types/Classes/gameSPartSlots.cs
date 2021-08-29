using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSPartSlots : RedBaseClass
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
	}
}
