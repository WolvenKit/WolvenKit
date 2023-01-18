using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDriveFollowEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetObjToFollow")] 
		public CWeakHandle<gameObject> TargetObjToFollow
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleDriveFollowEvent()
		{
			DistanceMin = 1.000000F;
			DistanceMax = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
