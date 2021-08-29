using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDoorOpen : ActionBool
	{
		private CName _slotID;
		private CBool _shouldAutoClose;
		private CFloat _autoCloseTime;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("shouldAutoClose")] 
		public CBool ShouldAutoClose
		{
			get => GetProperty(ref _shouldAutoClose);
			set => SetProperty(ref _shouldAutoClose, value);
		}

		[Ordinal(27)] 
		[RED("autoCloseTime")] 
		public CFloat AutoCloseTime
		{
			get => GetProperty(ref _autoCloseTime);
			set => SetProperty(ref _autoCloseTime, value);
		}
	}
}
