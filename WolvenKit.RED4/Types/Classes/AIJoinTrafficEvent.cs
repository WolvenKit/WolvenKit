
namespace WolvenKit.RED4.Types
{
	public partial class AIJoinTrafficEvent : AIAIEvent
	{
		public AIJoinTrafficEvent()
		{
			Name = "runAwayOnTraffic";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
