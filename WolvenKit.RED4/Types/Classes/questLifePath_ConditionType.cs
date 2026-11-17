
namespace WolvenKit.RED4.Types
{
	public partial class questLifePath_ConditionType : questIStatsScriptConditionType
	{
		public questLifePath_ConditionType()
		{
			EntityRef = new questUniversalRef();
			ScriptCondition = new LifePath_ScriptConditionType();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
