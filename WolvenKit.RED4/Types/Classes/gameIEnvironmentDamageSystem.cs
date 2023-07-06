
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEnvironmentDamageSystem : gameIGameSystem
	{
		public gameIEnvironmentDamageSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
