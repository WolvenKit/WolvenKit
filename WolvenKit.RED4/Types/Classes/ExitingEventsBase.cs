
namespace WolvenKit.RED4.Types
{
	public partial class ExitingEventsBase : VehicleEventsTransition
	{
		public ExitingEventsBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
