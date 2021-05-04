using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCombatConditions : PassiveAutonomousCondition
	{
		private CUInt32 _combatCommandCbId;
		private CUInt32 _roleCbId;
		private CUInt32 _threatCbId;
		private CUInt32 _playerCombatCbId;
		private CUInt32 _activeCombatConditionCbId;
		private CUInt32 _delayEvaluationCbId;

		[Ordinal(0)] 
		[RED("combatCommandCbId")] 
		public CUInt32 CombatCommandCbId
		{
			get => GetProperty(ref _combatCommandCbId);
			set => SetProperty(ref _combatCommandCbId, value);
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}

		[Ordinal(2)] 
		[RED("threatCbId")] 
		public CUInt32 ThreatCbId
		{
			get => GetProperty(ref _threatCbId);
			set => SetProperty(ref _threatCbId, value);
		}

		[Ordinal(3)] 
		[RED("playerCombatCbId")] 
		public CUInt32 PlayerCombatCbId
		{
			get => GetProperty(ref _playerCombatCbId);
			set => SetProperty(ref _playerCombatCbId, value);
		}

		[Ordinal(4)] 
		[RED("activeCombatConditionCbId")] 
		public CUInt32 ActiveCombatConditionCbId
		{
			get => GetProperty(ref _activeCombatConditionCbId);
			set => SetProperty(ref _activeCombatConditionCbId, value);
		}

		[Ordinal(5)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetProperty(ref _delayEvaluationCbId);
			set => SetProperty(ref _delayEvaluationCbId, value);
		}

		public PassiveCombatConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
