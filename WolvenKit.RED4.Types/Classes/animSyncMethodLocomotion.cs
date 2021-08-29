using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSyncMethodLocomotion : animISyncMethod
	{
		private CName _locomotionFeatureName;
		private CName _accelStopTimeEvent;

		[Ordinal(0)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get => GetProperty(ref _locomotionFeatureName);
			set => SetProperty(ref _locomotionFeatureName, value);
		}

		[Ordinal(1)] 
		[RED("accelStopTimeEvent")] 
		public CName AccelStopTimeEvent
		{
			get => GetProperty(ref _accelStopTimeEvent);
			set => SetProperty(ref _accelStopTimeEvent, value);
		}
	}
}
