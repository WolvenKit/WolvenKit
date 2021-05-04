using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIOffMeshConnectionComponent : entIComponent
	{
		private CArray<NodeRef> _offMeshConnectionNodesRefs;
		private CEnum<NavGenAgentSize> _agentSize;

		[Ordinal(3)] 
		[RED("offMeshConnectionNodesRefs")] 
		public CArray<NodeRef> OffMeshConnectionNodesRefs
		{
			get => GetProperty(ref _offMeshConnectionNodesRefs);
			set => SetProperty(ref _offMeshConnectionNodesRefs, value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetProperty(ref _agentSize);
			set => SetProperty(ref _agentSize, value);
		}

		public AIOffMeshConnectionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
