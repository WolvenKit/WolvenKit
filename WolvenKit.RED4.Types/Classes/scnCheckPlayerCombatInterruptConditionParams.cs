using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckPlayerCombatInterruptConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnCheckPlayerCombatInterruptConditionParams()
		{
			IsInCombat = true;
		}
	}
}
