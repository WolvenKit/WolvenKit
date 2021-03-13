using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIOffMeshConnectionComponent : entIComponent
	{
		[Ordinal(3)] [RED("offMeshConnectionNodesRefs")] public CArray<NodeRef> OffMeshConnectionNodesRefs { get; set; }
		[Ordinal(4)] [RED("agentSize")] public CEnum<NavGenAgentSize> AgentSize { get; set; }

		public AIOffMeshConnectionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
