using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterruptManagerNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>(value);
		}

		public scnInterruptManagerNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();
			InterruptionOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
