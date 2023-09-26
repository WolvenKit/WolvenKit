using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeBodySlamAttackEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(2)] 
		[RED("speedModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SpeedModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(3)] 
		[RED("stunModifier")] 
		public CHandle<gameStatModifierData_Deprecated> StunModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(4)] 
		[RED("chargeStage")] 
		public CInt32 ChargeStage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("attackSpawnDelay")] 
		public CFloat AttackSpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeToFullAttack")] 
		public CFloat TimeToFullAttack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("nextAttackRefresh")] 
		public CFloat NextAttackRefresh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("playBumpSFX")] 
		public CBool PlayBumpSFX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("bumpCallback")] 
		public CHandle<redCallbackObject> BumpCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("delayBetweenBumpSFX")] 
		public CFloat DelayBetweenBumpSFX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("bumpSFXCooldown")] 
		public CFloat BumpSFXCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("staminaCost")] 
		public CFloat StaminaCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("fullAttackIndex")] 
		public CInt32 FullAttackIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("weakAttackIndex")] 
		public CInt32 WeakAttackIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MeleeBodySlamAttackEvents()
		{
			FullAttackIndex = 2;
			WeakAttackIndex = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
