using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetFollowTarget : FollowVehicleTask
	{
		private CHandle<gameIBlackboard> _blackboard;
		private CWeakHandle<vehicleBaseObject> _vehicle;
		private CFloat _lastTime;
		private CFloat _timeout;
		private CFloat _timeoutDuration;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(2)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get => GetProperty(ref _lastTime);
			set => SetProperty(ref _lastTime, value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(4)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get => GetProperty(ref _timeoutDuration);
			set => SetProperty(ref _timeoutDuration, value);
		}
	}
}
