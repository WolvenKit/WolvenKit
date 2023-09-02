using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleSpawned_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questSpawnedVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<questSpawnedVehicleType>>();
			set => SetPropertyValue<CEnum<questSpawnedVehicleType>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(4)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("vehicleGlobalName")] 
		public CName VehicleGlobalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questVehicleSpawned_ConditionType()
		{
			VehicleRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
