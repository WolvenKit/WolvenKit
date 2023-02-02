
namespace WolvenKit.RED4.Types
{
	public partial class AIRunAwayEvent : AIAIEvent
	{
		public AIRunAwayEvent()
		{
			Name = "runAwayOnNavmesh";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
