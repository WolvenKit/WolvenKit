
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatPoolsListener : IScriptable
	{
		public gameIStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
