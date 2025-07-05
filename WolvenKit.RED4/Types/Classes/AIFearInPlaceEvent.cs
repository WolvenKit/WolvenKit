
namespace WolvenKit.RED4.Types
{
	public partial class AIFearInPlaceEvent : AIAIEvent
	{
		public AIFearInPlaceEvent()
		{
			Name = "fearInPlace";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
