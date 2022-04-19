
namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetSlotController : inkIWidgetSlotController
	{
		public inkWidgetSlotController()
		{
			Layout = new() { Padding = new(), Margin = new(), AnchorPoint = new(), SizeCoefficient = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
