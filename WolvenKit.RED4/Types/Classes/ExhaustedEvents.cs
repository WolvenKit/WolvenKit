using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExhaustedEvents : StaminaEventsTransition
	{
		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(2)] 
		[RED("disableStaminaRegenModifier")] 
		public CHandle<gameConstantStatModifierData_Deprecated> DisableStaminaRegenModifier
		{
			get => GetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public ExhaustedEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
