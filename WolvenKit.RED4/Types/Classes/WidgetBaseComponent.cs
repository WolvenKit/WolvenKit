
namespace WolvenKit.RED4.Types
{
	public abstract partial class WidgetBaseComponent : entIPlacedComponent
	{
		public WidgetBaseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
