using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questScene_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] [RED("entityReference")] public gameEntityReference EntityReference { get; set; }

		public questScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
