using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAndNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("numInSockets")] 
		public CUInt32 NumInSockets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnAndNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
