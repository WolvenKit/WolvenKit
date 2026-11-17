
namespace WolvenKit.RED4.Types
{
	public partial class gameKillTriggerNode : worldAreaShapeNode
	{
		public gameKillTriggerNode()
		{
			Color = new CColor { Red = 237, Green = 255, Alpha = 170 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
