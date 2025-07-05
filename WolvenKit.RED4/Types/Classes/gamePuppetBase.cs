
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePuppetBase : gameTimeDilatable
	{
		public gamePuppetBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
