using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("eventAction")] 
		public CName EventAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("internalEvent")] 
		public CHandle<gameActionInternalEvent> InternalEvent
		{
			get => GetPropertyValue<CHandle<gameActionInternalEvent>>();
			set => SetPropertyValue<CHandle<gameActionInternalEvent>>(value);
		}

		public gameActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
