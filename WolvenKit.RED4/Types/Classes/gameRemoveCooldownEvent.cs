
namespace WolvenKit.RED4.Types
{
	public partial class gameRemoveCooldownEvent : gameCooldownSystemEvent
	{
		public gameRemoveCooldownEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
