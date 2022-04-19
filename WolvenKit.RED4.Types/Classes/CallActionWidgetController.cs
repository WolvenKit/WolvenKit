using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(29)] 
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("callingAnimName")] 
		public CName CallingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("talkingAnimName")] 
		public CName TalkingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("status")] 
		public CEnum<IntercomStatus> Status
		{
			get => GetPropertyValue<CEnum<IntercomStatus>>();
			set => SetPropertyValue<CEnum<IntercomStatus>>(value);
		}

		public CallActionWidgetController()
		{
			StatusText = new();
			CallingAnimName = "calling_animation_maelstrom";
			TalkingAnimName = "talking_animation_maelstrom";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
