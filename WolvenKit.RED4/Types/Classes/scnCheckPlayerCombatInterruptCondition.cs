using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerCombatInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerCombatInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerCombatInterruptConditionParams>();
			set => SetPropertyValue<scnCheckPlayerCombatInterruptConditionParams>(value);
		}

		public scnCheckPlayerCombatInterruptCondition()
		{
			Params = new scnCheckPlayerCombatInterruptConditionParams { IsInCombat = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
