using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpawned_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(2)]  [RED("vehicleGlobalName")] public CName VehicleGlobalName { get; set; }
		[Ordinal(3)]  [RED("vehicleName")] public CString VehicleName { get; set; }
		[Ordinal(4)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(5)]  [RED("vehicleType")] public CEnum<questSpawnedVehicleType> VehicleType { get; set; }

		public questVehicleSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
