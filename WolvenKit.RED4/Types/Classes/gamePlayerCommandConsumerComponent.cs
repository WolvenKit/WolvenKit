
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerCommandConsumerComponent : entIComponent
	{
		public gamePlayerCommandConsumerComponent()
		{
			Name = "PlayerCommandConsumer";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
