
namespace WolvenKit.RED4.Types
{
	public partial class gameObjectPS : gamePersistentState
	{
		public gameObjectPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
