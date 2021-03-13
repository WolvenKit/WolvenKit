using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAgentInfoDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)] [RED("entityId")] public entEntityID EntityId { get; set; }
		[Ordinal(1)] [RED("agentName")] public CString AgentName { get; set; }
		[Ordinal(2)] [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(3)] [RED("entries")] public CArray<AIbehaviorAgentInfoDebuggerCommandEntry> Entries { get; set; }

		public AIbehaviorAgentInfoDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
