using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCallbackSystemEvent : IScriptable
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameCallbackSystemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
