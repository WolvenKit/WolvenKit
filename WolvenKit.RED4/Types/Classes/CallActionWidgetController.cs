using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(32)] 
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("callingAnimName")] 
		public CName CallingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("talkingAnimName")] 
		public CName TalkingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("status")] 
		public CEnum<IntercomStatus> Status
		{
			get => GetPropertyValue<CEnum<IntercomStatus>>();
			set => SetPropertyValue<CEnum<IntercomStatus>>(value);
		}

		public CallActionWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
