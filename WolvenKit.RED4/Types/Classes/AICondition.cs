
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICondition : IScriptable
	{
		public AICondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
