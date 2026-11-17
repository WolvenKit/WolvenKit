
namespace WolvenKit.RED4.Types
{
	public partial class worldPreventionFreeAreaNode : worldAreaShapeNode
	{
		public worldPreventionFreeAreaNode()
		{
			Color = new CColor { Red = 32, Green = 32, Blue = 32, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
