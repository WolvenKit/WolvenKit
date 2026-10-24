
namespace WolvenKit.RED4.Types
{
	public partial class scnDeletionMarkerNode : scnSceneGraphNode
	{
		public scnDeletionMarkerNode()
		{
			NodeId = new scnNodeId();
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
