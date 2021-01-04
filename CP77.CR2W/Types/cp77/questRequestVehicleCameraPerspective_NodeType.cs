using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRequestVehicleCameraPerspective_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("cameraPerspective")] public CEnum<questVehicleCameraPerspective> CameraPerspective { get; set; }

		public questRequestVehicleCameraPerspective_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
