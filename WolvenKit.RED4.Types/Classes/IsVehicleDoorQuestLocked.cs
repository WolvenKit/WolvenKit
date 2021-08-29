using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsVehicleDoorQuestLocked : gameIScriptablePrereq
	{
		private CName _slotName;
		private CBool _isCheckInverted;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get => GetProperty(ref _isCheckInverted);
			set => SetProperty(ref _isCheckInverted, value);
		}
	}
}
