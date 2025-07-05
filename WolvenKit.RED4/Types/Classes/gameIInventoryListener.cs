
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIInventoryListener : IScriptable
	{
		public gameIInventoryListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
