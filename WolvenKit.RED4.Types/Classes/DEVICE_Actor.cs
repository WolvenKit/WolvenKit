
namespace WolvenKit.RED4.Types
{
	public partial class DEVICE_Actor : gameHudActor
	{
		public DEVICE_Actor()
		{
			Type = Enums.HUDActorType.DEVICE;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
