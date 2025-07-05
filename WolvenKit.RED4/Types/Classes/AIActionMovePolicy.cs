
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIActionMovePolicy : IScriptable
	{
		public AIActionMovePolicy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
