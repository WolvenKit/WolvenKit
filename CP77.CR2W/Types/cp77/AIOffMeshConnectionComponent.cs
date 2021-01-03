using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIOffMeshConnectionComponent : entIComponent
	{
		[Ordinal(0)]  [RED("agentSize")] public CEnum<NavGenAgentSize> AgentSize { get; set; }
		[Ordinal(1)]  [RED("offMeshConnectionNodesRefs")] public CArray<NodeRef> OffMeshConnectionNodesRefs { get; set; }

		public AIOffMeshConnectionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
