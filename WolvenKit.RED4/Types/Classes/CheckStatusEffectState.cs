using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckStatusEffectState : AIStatusEffectCondition
	{
		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}

		[Ordinal(1)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get => GetPropertyValue<CEnum<EstatusEffectsState>>();
			set => SetPropertyValue<CEnum<EstatusEffectsState>>(value);
		}

		[Ordinal(2)] 
		[RED("topPrioStatusEffect")] 
		public CHandle<gameStatusEffect> TopPrioStatusEffect
		{
			get => GetPropertyValue<CHandle<gameStatusEffect>>();
			set => SetPropertyValue<CHandle<gameStatusEffect>>(value);
		}

		public CheckStatusEffectState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
