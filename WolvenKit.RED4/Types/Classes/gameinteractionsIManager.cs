
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameinteractionsIManager : gameIGameSystem
	{
		public gameinteractionsIManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
