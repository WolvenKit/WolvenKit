using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIOffMeshConnectionComponent : entIComponent
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
	}
}
