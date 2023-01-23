using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIOffMeshConnectionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("offMeshConnectionNodesRefs")] 
		public CArray<NodeRef> OffMeshConnectionNodesRefs
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetPropertyValue<CEnum<NavGenAgentSize>>();
			set => SetPropertyValue<CEnum<NavGenAgentSize>>(value);
		}

		public AIOffMeshConnectionComponent()
		{
			Name = "Component";
			OffMeshConnectionNodesRefs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
