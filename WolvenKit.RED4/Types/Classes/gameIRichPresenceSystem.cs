
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIRichPresenceSystem : gameIGameSystem
	{
		public gameIRichPresenceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
