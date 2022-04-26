
namespace WolvenKit.RED4.Types
{
	public partial class scnXorNode : scnSceneGraphNode
	{
		public scnXorNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
