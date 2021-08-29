using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlarmEvent : redEvent
	{
		private CBool _isValid;
		private gameDelayID _iD;

		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameDelayID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}
	}
}
