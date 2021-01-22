using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommandEntry : CVariable
	{
		[Ordinal(0)]  [RED("failure")] public CHandle<gamedebugFailure> Failure { get; set; }
		[Ordinal(1)]  [RED("generation")] public CUInt32 Generation { get; set; }
		[Ordinal(2)]  [RED("nodeId")] public CGUID NodeId { get; set; }
		[Ordinal(3)]  [RED("status")] public CEnum<AIbehaviorDebugNodeStatus> Status { get; set; }

		public AIbehaviorNodeStatusDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
