using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleWindowClose : ActionBool
	{
		private CName _slotID;
		private CName _speed;
		private CBool _isInteractionSource;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("speed")] 
		public CName Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(27)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get => GetProperty(ref _isInteractionSource);
			set => SetProperty(ref _isInteractionSource, value);
		}
	}
}
