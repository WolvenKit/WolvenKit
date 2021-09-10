using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckIntScenarioActiveReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckIntScenarioActiveReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckIntScenarioActiveReturnConditionParams>();
			set => SetPropertyValue<scnCheckIntScenarioActiveReturnConditionParams>(value);
		}

		public scnCheckIntScenarioActiveReturnCondition()
		{
			Params = new();
		}
	}
}
