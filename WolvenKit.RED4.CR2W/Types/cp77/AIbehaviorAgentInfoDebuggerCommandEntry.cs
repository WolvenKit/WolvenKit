using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAgentInfoDebuggerCommandEntry : CVariable
	{
		[Ordinal(0)] [RED("callStack")] public AIbehaviorBehaviorInstanceCallStack CallStack { get; set; }
		[Ordinal(1)] [RED("behaviorResourcePath")] public CString BehaviorResourcePath { get; set; }

		public AIbehaviorAgentInfoDebuggerCommandEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
