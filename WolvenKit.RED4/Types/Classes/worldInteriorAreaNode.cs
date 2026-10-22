
namespace WolvenKit.RED4.Types
{
	public partial class worldInteriorAreaNode : worldTriggerAreaNode
	{
		public worldInteriorAreaNode()
		{
			Color = new CColor { Red = 128, Green = 128, Blue = 32, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
