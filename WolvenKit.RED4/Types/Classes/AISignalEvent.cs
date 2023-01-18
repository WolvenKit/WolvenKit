
namespace WolvenKit.RED4.Types
{
	public partial class AISignalEvent : AITaggedAIEvent
	{
		public AISignalEvent()
		{
			Name = "Behavior.Signal";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
