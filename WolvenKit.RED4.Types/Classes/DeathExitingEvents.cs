
namespace WolvenKit.RED4.Types
{
	public partial class DeathExitingEvents : ImmediateExitWithForceEvents
	{
		public DeathExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
