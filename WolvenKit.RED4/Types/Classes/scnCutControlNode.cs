
namespace WolvenKit.RED4.Types
{
	public partial class scnCutControlNode : scnSceneGraphNode
	{
		public scnCutControlNode()
		{
			NodeId = new scnNodeId();
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
