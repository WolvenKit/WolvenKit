using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

		public GetFollowTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
