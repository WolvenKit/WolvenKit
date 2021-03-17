using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpawned_ConditionType : questIVehicleConditionType
	{
		private CEnum<questSpawnedVehicleType> _vehicleType;
		private gameEntityReference _vehicleRef;
		private CUInt32 _count;
		private CEnum<EComparisonType> _comparisonType;
		private CString _vehicleName;
		private CName _vehicleGlobalName;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questSpawnedVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(4)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetProperty(ref _vehicleName);
			set => SetProperty(ref _vehicleName, value);
		}

		[Ordinal(5)] 
		[RED("vehicleGlobalName")] 
		public CName VehicleGlobalName
		{
			get => GetProperty(ref _vehicleGlobalName);
			set => SetProperty(ref _vehicleGlobalName, value);
		}

		public questVehicleSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
