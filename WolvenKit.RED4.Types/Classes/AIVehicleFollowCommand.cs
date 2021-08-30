using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIVehicleFollowCommand : AIVehicleCommand
	{
		private CWeakHandle<gameObject> _target;
		private CFloat _secureTimeOut;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _useTraffic;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;
		private CBool _allowStubMovement;

		[Ordinal(6)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(7)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(8)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(9)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(10)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetProperty(ref _stopWhenTargetReached);
			set => SetProperty(ref _stopWhenTargetReached, value);
		}

		[Ordinal(11)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(12)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(13)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		[Ordinal(14)] 
		[RED("allowStubMovement")] 
		public CBool AllowStubMovement
		{
			get => GetProperty(ref _allowStubMovement);
			set => SetProperty(ref _allowStubMovement, value);
		}

		public AIVehicleFollowCommand()
		{
			_secureTimeOut = 2.000000F;
			_distanceMin = 0.500000F;
			_distanceMax = 1.000000F;
			_stopWhenTargetReached = true;
			_useTraffic = true;
		}
	}
}
