using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckWoundedStatusEffectState : AIStatusEffectCondition
	{
		[Ordinal(0)] 
		[RED("stateToCheck")] 
		public CEnum<EstatusEffectsState> StateToCheck
		{
			get => GetPropertyValue<CEnum<EstatusEffectsState>>();
			set => SetPropertyValue<CEnum<EstatusEffectsState>>(value);
		}

		public CheckWoundedStatusEffectState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
