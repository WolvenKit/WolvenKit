
namespace WolvenKit.RED4.Types
{
	public partial class BaseContextEvents : InputContextTransitionEvents
	{
		public BaseContextEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
