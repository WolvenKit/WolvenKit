
namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetSlotController : inkIWidgetSlotController
	{
		public inkWidgetSlotController()
		{
			Layout = new inkWidgetLayout { Padding = new inkMargin(), Margin = new inkMargin(), AnchorPoint = new Vector2(), SizeCoefficient = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
