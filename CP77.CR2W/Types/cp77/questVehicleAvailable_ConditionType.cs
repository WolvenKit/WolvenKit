using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleType")] public CEnum<questAvailableVehicleType> VehicleType { get; set; }
		[Ordinal(1)] [RED("vehicleName")] public CString VehicleName { get; set; }

		public questVehicleAvailable_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
