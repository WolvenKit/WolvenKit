
namespace WolvenKit.RED4.Types
{
	public partial class gameComponentPS : gamePersistentState
	{
		public gameComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
