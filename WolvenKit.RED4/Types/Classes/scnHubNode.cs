
namespace WolvenKit.RED4.Types
{
	public partial class scnHubNode : scnSceneGraphNode
	{
		public scnHubNode()
		{
			NodeId = new scnNodeId();
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
