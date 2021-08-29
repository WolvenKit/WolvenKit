using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorWidgetCustomData : WidgetCustomData
	{
		private CInt32 _passcode;
		private CName _card;
		private CBool _isPasswordKnown;

		[Ordinal(0)] 
		[RED("passcode")] 
		public CInt32 Passcode
		{
			get => GetProperty(ref _passcode);
			set => SetProperty(ref _passcode, value);
		}

		[Ordinal(1)] 
		[RED("card")] 
		public CName Card
		{
			get => GetProperty(ref _card);
			set => SetProperty(ref _card, value);
		}

		[Ordinal(2)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get => GetProperty(ref _isPasswordKnown);
			set => SetProperty(ref _isPasswordKnown, value);
		}
	}
}
