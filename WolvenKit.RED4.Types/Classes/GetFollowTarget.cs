using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetFollowTarget : FollowVehicleTask
	{
		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(2)] 
		[RED("lastTime")] 
		public CFloat LastTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("timeoutDuration")] 
		public CFloat TimeoutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GetFollowTarget()
		{
			LastTime = -1.000000F;
			TimeoutDuration = 0.100000F;
		}
	}
}
