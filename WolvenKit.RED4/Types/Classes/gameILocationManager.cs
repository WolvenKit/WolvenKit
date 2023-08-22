
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameILocationManager : gameIGameSystem
	{
		public gameILocationManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
