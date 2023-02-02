
namespace WolvenKit.RED4.Types
{
	public partial class WidgetBaseComponent : entIPlacedComponent
	{
		public WidgetBaseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
