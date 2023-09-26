using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSpawnRequestResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("requestID")] 
		public CUInt32 RequestID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("policeStrategy")] 
		public CEnum<vehiclePoliceStrategy> PoliceStrategy
		{
			get => GetPropertyValue<CEnum<vehiclePoliceStrategy>>();
			set => SetPropertyValue<CEnum<vehiclePoliceStrategy>>(value);
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gameDynamicVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<gameDynamicVehicleType>>();
			set => SetPropertyValue<CEnum<gameDynamicVehicleType>>(value);
		}

		[Ordinal(3)] 
		[RED("spawnedObjects")] 
		public CArray<CWeakHandle<gameObject>> SpawnedObjects
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(4)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSpawnRequestResult()
		{
			SpawnedObjects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
