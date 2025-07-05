
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIScriptSquad : IScriptable
	{
		public AIScriptSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
