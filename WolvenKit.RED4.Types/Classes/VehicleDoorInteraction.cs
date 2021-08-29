using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDoorInteraction : ActionBool
	{
		private CName _slotID;
		private CBool _isInteractionSource;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get => GetProperty(ref _isInteractionSource);
			set => SetProperty(ref _isInteractionSource, value);
		}
	}
}
