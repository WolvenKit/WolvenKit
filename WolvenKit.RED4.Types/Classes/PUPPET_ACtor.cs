
namespace WolvenKit.RED4.Types
{
	public partial class PUPPET_ACtor : gameHudActor
	{
		public PUPPET_ACtor()
		{
			Type = Enums.HUDActorType.PUPPET;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
