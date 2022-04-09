using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimGraphExternalEvent : ISerializable
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimGraphExternalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
