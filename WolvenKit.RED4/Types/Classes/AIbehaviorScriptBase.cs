
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorScriptBase : IScriptable
	{
		public AIbehaviorScriptBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
