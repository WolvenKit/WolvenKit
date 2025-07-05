
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITransactionSystem : gameIGameSystem
	{
		public gameITransactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
