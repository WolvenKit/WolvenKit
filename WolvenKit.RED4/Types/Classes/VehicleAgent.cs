using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleAgent : AgentBase
	{
		[Ordinal(3)] 
		[RED("unit")] 
		public CWeakHandle<vehicleBaseObject> Unit
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(4)] 
		[RED("passangers")] 
		public CInt32 Passangers
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("slotsTotal")] 
		public CInt32 SlotsTotal
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("slotsReserved")] 
		public CInt32 SlotsReserved
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("slotsAvailable")] 
		public CInt32 SlotsAvailable
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("everHadPassengers")] 
		public CBool EverHadPassengers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("distanceToPlayerSquared")] 
		public CFloat DistanceToPlayerSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("lifetimeStatus")] 
		public CEnum<LifetimeStatus> LifetimeStatus
		{
			get => GetPropertyValue<CEnum<LifetimeStatus>>();
			set => SetPropertyValue<CEnum<LifetimeStatus>>(value);
		}

		[Ordinal(11)] 
		[RED("nearTimeStamp")] 
		public CFloat NearTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VehicleAgent()
		{
			NearTimeStamp = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
