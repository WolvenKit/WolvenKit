using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerCombatReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerCombatReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerCombatReturnConditionParams>();
			set => SetPropertyValue<scnCheckPlayerCombatReturnConditionParams>(value);
		}

		public scnCheckPlayerCombatReturnCondition()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
