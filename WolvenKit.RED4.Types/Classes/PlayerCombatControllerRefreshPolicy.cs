using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerRefreshPolicy : RedBaseClass
	{
		private CEnum<PlayerCombatControllerRefreshPolicyEnum> _crouchActive;
		private CEnum<PlayerCombatControllerRefreshPolicyEnum> _crouchTimerPassed;
		private CEnum<PlayerCombatControllerRefreshPolicyEnum> _squadInCombat;
		private CEnum<PlayerCombatControllerRefreshPolicyEnum> _usingJhonnyReplacer;
		private CEnum<PlayerCombatControllerRefreshPolicyEnum> _usingQuickHack;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}

		[Ordinal(1)] 
		[RED("crouchTimerPassed")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> CrouchTimerPassed
		{
			get => GetProperty(ref _crouchTimerPassed);
			set => SetProperty(ref _crouchTimerPassed, value);
		}

		[Ordinal(2)] 
		[RED("squadInCombat")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> SquadInCombat
		{
			get => GetProperty(ref _squadInCombat);
			set => SetProperty(ref _squadInCombat, value);
		}

		[Ordinal(3)] 
		[RED("usingJhonnyReplacer")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> UsingJhonnyReplacer
		{
			get => GetProperty(ref _usingJhonnyReplacer);
			set => SetProperty(ref _usingJhonnyReplacer, value);
		}

		[Ordinal(4)] 
		[RED("usingQuickHack")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> UsingQuickHack
		{
			get => GetProperty(ref _usingQuickHack);
			set => SetProperty(ref _usingQuickHack, value);
		}
	}
}
