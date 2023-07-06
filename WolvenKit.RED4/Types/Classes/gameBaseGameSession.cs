
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameBaseGameSession : RedBaseClass
	{
		public gameBaseGameSession()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
