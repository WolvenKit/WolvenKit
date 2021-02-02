using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleUnlockedVehicle : CVariable
	{
		[Ordinal(0)]  [RED("vehicleID")] public vehicleGarageVehicleID VehicleID { get; set; }
		[Ordinal(1)]  [RED("health")] public CFloat Health { get; set; }

		public vehicleUnlockedVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
