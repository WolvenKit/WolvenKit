using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AgentRegistry : IScriptable
	{
		[Ordinal(0)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(1)] [RED("agents")] public CArray<Agent> Agents { get; set; }
		[Ordinal(2)] [RED("agentsLock")] public ScriptReentrantRWLock AgentsLock { get; set; }
		[Ordinal(3)] [RED("maxReprimandsPerNPC")] public CInt32 MaxReprimandsPerNPC { get; set; }
		[Ordinal(4)] [RED("maxReprimandsPerDEVICE")] public CInt32 MaxReprimandsPerDEVICE { get; set; }

		public AgentRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
