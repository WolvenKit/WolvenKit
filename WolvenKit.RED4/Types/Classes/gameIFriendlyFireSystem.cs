
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIFriendlyFireSystem : gameIGameSystem
	{
		public gameIFriendlyFireSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
