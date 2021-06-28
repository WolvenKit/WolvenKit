using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStatusEffectState : AIStatusEffectCondition
	{
		private CEnum<gamedataStatusEffectType> _statusEffectType;
		private CEnum<EstatusEffectsState> _stateToCheck;
		private CHandle<gameStatusEffect> _topPrioStatusEffect;

		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get => GetProperty(ref _statusEffectType);
			set => SetProperty(ref _statusEffectType, value);
		}

		[Ordinal(1)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get => GetProperty(ref _stateToCheck);
			set => SetProperty(ref _stateToCheck, value);
		}

		[Ordinal(2)] 
		[RED("topPrioStatusEffect")] 
		public CHandle<gameStatusEffect> TopPrioStatusEffect
		{
			get => GetProperty(ref _topPrioStatusEffect);
			set => SetProperty(ref _topPrioStatusEffect, value);
		}

		public CheckStatusEffectState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
