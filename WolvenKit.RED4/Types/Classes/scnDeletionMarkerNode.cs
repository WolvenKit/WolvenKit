
namespace WolvenKit.RED4.Types
{
	public partial class scnDeletionMarkerNode : scnSceneGraphNode
	{
		public scnDeletionMarkerNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
