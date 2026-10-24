
namespace WolvenKit.RED4.Types
{
	public partial class scnXorNode : scnSceneGraphNode
	{
		public scnXorNode()
		{
			NodeId = new scnNodeId();
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
