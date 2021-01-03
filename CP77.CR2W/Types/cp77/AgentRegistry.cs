using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AgentRegistry : IScriptable
	{
		[Ordinal(0)]  [RED("agents")] public CArray<Agent> Agents { get; set; }
		[Ordinal(1)]  [RED("agentsLock")] public ScriptReentrantRWLock AgentsLock { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("maxReprimandsPerDEVICE")] public CInt32 MaxReprimandsPerDEVICE { get; set; }
		[Ordinal(4)]  [RED("maxReprimandsPerNPC")] public CInt32 MaxReprimandsPerNPC { get; set; }

		public AgentRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
