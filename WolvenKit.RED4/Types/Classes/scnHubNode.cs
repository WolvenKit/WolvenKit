
namespace WolvenKit.RED4.Types
{
	public partial class scnHubNode : scnSceneGraphNode
	{
		public scnHubNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
