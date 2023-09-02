
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIBlackboard : IScriptable
	{
		public gameIBlackboard()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
