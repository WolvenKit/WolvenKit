using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleExternalDoorRequestEvent : redEvent
	{
		private CName _slotName;
		private CBool _autoClose;
		private CFloat _autoCloseTime;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("autoClose")] 
		public CBool AutoClose
		{
			get => GetProperty(ref _autoClose);
			set => SetProperty(ref _autoClose, value);
		}

		[Ordinal(2)] 
		[RED("autoCloseTime")] 
		public CFloat AutoCloseTime
		{
			get => GetProperty(ref _autoCloseTime);
			set => SetProperty(ref _autoCloseTime, value);
		}
	}
}
