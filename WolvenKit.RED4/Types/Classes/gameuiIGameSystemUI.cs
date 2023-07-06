
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiIGameSystemUI : gameIGameSystem
	{
		public gameuiIGameSystemUI()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
