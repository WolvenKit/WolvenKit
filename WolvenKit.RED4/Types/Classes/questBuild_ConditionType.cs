
namespace WolvenKit.RED4.Types
{
	public partial class questBuild_ConditionType : questIStatsScriptConditionType
	{
		public questBuild_ConditionType()
		{
			EntityRef = new questUniversalRef();
			ScriptCondition = new Build_ScriptConditionType();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
