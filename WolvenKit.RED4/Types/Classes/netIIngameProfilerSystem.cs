
namespace WolvenKit.RED4.Types
{
	public abstract partial class netIIngameProfilerSystem : gameIGameSystem
	{
		public netIIngameProfilerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
