using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleBumpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("impactVelocityChange")] 
		public CFloat ImpactVelocityChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("isInTraffic")] 
		public CBool IsInTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hitVehicle")] 
		public CWeakHandle<vehicleBaseObject> HitVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(3)] 
		[RED("hitNormal")] 
		public Vector3 HitNormal
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public vehicleVehicleBumpEvent()
		{
			HitNormal = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
