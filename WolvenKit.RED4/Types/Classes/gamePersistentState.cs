
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePersistentState : IScriptable
	{
		public gamePersistentState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
