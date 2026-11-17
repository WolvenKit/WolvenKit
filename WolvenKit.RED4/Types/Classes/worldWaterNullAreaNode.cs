
namespace WolvenKit.RED4.Types
{
	public partial class worldWaterNullAreaNode : worldAreaShapeNode
	{
		public worldWaterNullAreaNode()
		{
			Color = new CColor { Red = 64, Green = 64, Blue = 128, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
