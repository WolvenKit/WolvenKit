
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITelemetrySystem : gameIGameSystem
	{
		public gameITelemetrySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
