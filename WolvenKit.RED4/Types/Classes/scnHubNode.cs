
namespace WolvenKit.RED4.Types
{
	public partial class scnHubNode : scnSceneGraphNode
	{
		public scnHubNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
