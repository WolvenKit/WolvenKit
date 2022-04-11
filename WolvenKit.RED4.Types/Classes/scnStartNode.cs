
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnStartNode : scnSceneGraphNode
	{

		public scnStartNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
		}
	}
}
