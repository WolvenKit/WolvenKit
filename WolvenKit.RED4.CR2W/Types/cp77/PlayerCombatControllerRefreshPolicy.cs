using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCombatControllerRefreshPolicy : CVariable
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

		public PlayerCombatControllerRefreshPolicy(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
