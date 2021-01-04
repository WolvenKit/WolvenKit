using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUnassignAll_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(1)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }

		public questUnassignAll_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
