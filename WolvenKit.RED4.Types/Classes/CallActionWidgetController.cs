using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _statusText;
		private CName _callingAnimName;
		private CName _talkingAnimName;
		private CEnum<IntercomStatus> _status;

		[Ordinal(29)] 
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetProperty(ref _statusText);
			set => SetProperty(ref _statusText, value);
		}

		[Ordinal(30)] 
		[RED("callingAnimName")] 
		public CName CallingAnimName
		{
			get => GetProperty(ref _callingAnimName);
			set => SetProperty(ref _callingAnimName, value);
		}

		[Ordinal(31)] 
		[RED("talkingAnimName")] 
		public CName TalkingAnimName
		{
			get => GetProperty(ref _talkingAnimName);
			set => SetProperty(ref _talkingAnimName, value);
		}

		[Ordinal(32)] 
		[RED("status")] 
		public CEnum<IntercomStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		public CallActionWidgetController()
		{
			_callingAnimName = "calling_animation_maelstrom";
			_talkingAnimName = "talking_animation_maelstrom";
		}
	}
}
