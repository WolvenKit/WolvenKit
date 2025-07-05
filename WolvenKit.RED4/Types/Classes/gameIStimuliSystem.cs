
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStimuliSystem : gameIGameSystem
	{
		public gameIStimuliSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
