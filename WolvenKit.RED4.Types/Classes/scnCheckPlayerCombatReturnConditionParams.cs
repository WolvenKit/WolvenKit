using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerCombatReturnConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnCheckPlayerCombatReturnConditionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
