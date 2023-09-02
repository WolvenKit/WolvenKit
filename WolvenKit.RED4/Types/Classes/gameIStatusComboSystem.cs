
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatusComboSystem : gameIGameSystem
	{
		public gameIStatusComboSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
