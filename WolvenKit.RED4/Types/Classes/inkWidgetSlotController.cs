
namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetSlotController : inkIWidgetSlotController
	{
		public inkWidgetSlotController()
		{
			Layout = new inkWidgetLayout();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
