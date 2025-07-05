using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSyncMethodByEvent : animISyncMethod
	{
		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animSyncMethodByEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
