
namespace WolvenKit.RED4.Types
{
	public partial class scnStartNode : scnSceneGraphNode
	{
		public scnStartNode()
		{
			NodeId = new scnNodeId();
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
