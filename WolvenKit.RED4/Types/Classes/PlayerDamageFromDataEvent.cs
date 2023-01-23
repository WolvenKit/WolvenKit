
namespace WolvenKit.RED4.Types
{
	public partial class PlayerDamageFromDataEvent : gameTickableEvent
	{
		public PlayerDamageFromDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
