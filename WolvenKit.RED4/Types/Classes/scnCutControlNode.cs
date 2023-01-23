
namespace WolvenKit.RED4.Types
{
	public partial class scnCutControlNode : scnSceneGraphNode
	{
		public scnCutControlNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
