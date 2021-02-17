using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)] [RED("behaviorResourceHash")] public CUInt32 BehaviorResourceHash { get; set; }
		[Ordinal(1)] [RED("generation")] public CUInt32 Generation { get; set; }
		[Ordinal(2)] [RED("entries")] public CArray<AIbehaviorNodeStatusDebuggerCommandEntry> Entries { get; set; }

		public AIbehaviorNodeStatusDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
