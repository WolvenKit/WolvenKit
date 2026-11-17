
namespace WolvenKit.RED4.Types
{
	public partial class gameWorldBoundaryNode : worldAreaShapeNode
	{
		public gameWorldBoundaryNode()
		{
			Color = new CColor { Red = 255, Green = 237, Alpha = 170 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
