
namespace WolvenKit.RED4.Types
{
	public partial class GAMEOBJECT_Actor : gameHudActor
	{
		public GAMEOBJECT_Actor()
		{
			Type = Enums.HUDActorType.GAME_OBJECT;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
