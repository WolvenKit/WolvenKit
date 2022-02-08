using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerActiveFlags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CBool CrouchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("crouchTimerPassed")] 
		public CBool CrouchTimerPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("usingJhonnyReplacer")] 
		public CBool UsingJhonnyReplacer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("usingQuickHack")] 
		public CBool UsingQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
