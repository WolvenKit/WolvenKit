
namespace WolvenKit.RED4.Types
{
	public abstract partial class ScriptConditionTypeBase : IScriptable
	{
		public ScriptConditionTypeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
