using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _statusText;
		private CName _callingAnimName;
		private CName _talkingAnimName;
		private CEnum<IntercomStatus> _status;

		[Ordinal(28)] 
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetProperty(ref _statusText);
			set => SetProperty(ref _statusText, value);
		}

		[Ordinal(29)] 
		[RED("callingAnimName")] 
		public CName CallingAnimName
		{
			get => GetProperty(ref _callingAnimName);
			set => SetProperty(ref _callingAnimName, value);
		}

		[Ordinal(30)] 
		[RED("talkingAnimName")] 
		public CName TalkingAnimName
		{
			get => GetProperty(ref _talkingAnimName);
			set => SetProperty(ref _talkingAnimName, value);
		}

		[Ordinal(31)] 
		[RED("status")] 
		public CEnum<IntercomStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		public CallActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
