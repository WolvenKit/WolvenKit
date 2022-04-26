using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSyncMethodLocomotion : animISyncMethod
	{
		[Ordinal(0)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("accelStopTimeEvent")] 
		public CName AccelStopTimeEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animSyncMethodLocomotion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
