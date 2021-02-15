using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocketId : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("osockStamp")] public scnOutputSocketStamp OsockStamp { get; set; }

		public scnOutputSocketId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
