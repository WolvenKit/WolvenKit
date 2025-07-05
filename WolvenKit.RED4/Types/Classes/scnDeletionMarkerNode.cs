
namespace WolvenKit.RED4.Types
{
	public partial class scnDeletionMarkerNode : scnSceneGraphNode
	{
		public scnDeletionMarkerNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
