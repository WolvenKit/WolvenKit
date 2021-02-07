using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questFormConvoy_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("leaderRef")] public gameEntityReference LeaderRef { get; set; }
		[Ordinal(1)]  [RED("formationType")] public CEnum<vehicleFormationType> FormationType { get; set; }

		public questFormConvoy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
