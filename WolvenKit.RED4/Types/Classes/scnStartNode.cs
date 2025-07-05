
namespace WolvenKit.RED4.Types
{
	public partial class scnStartNode : scnSceneGraphNode
	{
		public scnStartNode()
		{
			NodeId = new scnNodeId { Id = uint.MaxValue };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
