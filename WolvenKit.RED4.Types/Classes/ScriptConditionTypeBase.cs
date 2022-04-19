
namespace WolvenKit.RED4.Types
{
	public partial class ScriptConditionTypeBase : IScriptable
	{
		public ScriptConditionTypeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
