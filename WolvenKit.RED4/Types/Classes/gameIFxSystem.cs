
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIFxSystem : gameIGameSystem
	{
		public gameIFxSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
