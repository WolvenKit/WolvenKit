using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAgentInfoDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		[Ordinal(0)]  [RED("entityId")] public entEntityID EntityId { get; set; }
		[Ordinal(1)]  [RED("agentName")] public CString AgentName { get; set; }
		[Ordinal(2)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(3)]  [RED("entries")] public CArray<AIbehaviorAgentInfoDebuggerCommandEntry> Entries { get; set; }

		public AIbehaviorAgentInfoDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
