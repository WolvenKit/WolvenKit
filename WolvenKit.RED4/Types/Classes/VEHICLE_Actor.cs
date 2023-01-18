
namespace WolvenKit.RED4.Types
{
	public partial class VEHICLE_Actor : gameHudActor
	{
		public VEHICLE_Actor()
		{
			Type = Enums.HUDActorType.VEHICLE;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
