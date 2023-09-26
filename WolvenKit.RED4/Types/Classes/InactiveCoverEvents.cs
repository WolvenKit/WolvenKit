
namespace WolvenKit.RED4.Types
{
	public partial class InactiveCoverEvents : CoverActionEventsTransition
	{
		public InactiveCoverEvents()
		{
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
