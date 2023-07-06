
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAttitudeManager : gameIGameSystem
	{
		public gameIAttitudeManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
