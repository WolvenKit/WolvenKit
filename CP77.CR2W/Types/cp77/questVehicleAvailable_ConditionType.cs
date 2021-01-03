using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("vehicleName")] public CString VehicleName { get; set; }
		[Ordinal(1)]  [RED("vehicleType")] public CEnum<questAvailableVehicleType> VehicleType { get; set; }

		public questVehicleAvailable_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
