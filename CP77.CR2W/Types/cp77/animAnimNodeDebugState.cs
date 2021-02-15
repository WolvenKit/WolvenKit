using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeDebugState : ISerializable
	{
		[Ordinal(0)] [RED("nodeId")] public CUInt32 NodeId { get; set; }
		[Ordinal(1)] [RED("active")] public CBool Active { get; set; }

		public animAnimNodeDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
