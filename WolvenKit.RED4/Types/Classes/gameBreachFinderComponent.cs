using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBreachFinderComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("audioSystem")] 
		public CHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetPropertyValue<CHandle<gameGameAudioSystem>>();
			set => SetPropertyValue<CHandle<gameGameAudioSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(6)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("almostTimeout")] 
		public CBool AlmostTimeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("breachDurationMin")] 
		public CFloat BreachDurationMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("breachDurationMax")] 
		public CFloat BreachDurationMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("breachDurationIncreasePerStreak")] 
		public CFloat BreachDurationIncreasePerStreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("breachDurationIncreaseForAnyStreak")] 
		public CFloat BreachDurationIncreaseForAnyStreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("breachDurationIncreaseOnFirstLookat")] 
		public CFloat BreachDurationIncreaseOnFirstLookat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("breachDurationIncreaseOnFirstHit")] 
		public CFloat BreachDurationIncreaseOnFirstHit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("breachCooldownMin")] 
		public CFloat BreachCooldownMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("breachCooldownMax")] 
		public CFloat BreachCooldownMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("breachCooldownDecreasePerStreak")] 
		public CFloat BreachCooldownDecreasePerStreak
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("onBreachDestroyedAttackRecord")] 
		public CHandle<gamedataAttack_GameEffect_Record> OnBreachDestroyedAttackRecord
		{
			get => GetPropertyValue<CHandle<gamedataAttack_GameEffect_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_GameEffect_Record>>(value);
		}

		[Ordinal(18)] 
		[RED("onBreachDestroyedHealthToDamage")] 
		public CFloat OnBreachDestroyedHealthToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("onBreachDestroyedHealthToDamageBoss")] 
		public CFloat OnBreachDestroyedHealthToDamageBoss
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("desiredBreachDuration")] 
		public CFloat DesiredBreachDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("cooldownAfterBreach")] 
		public CFloat CooldownAfterBreach
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBreachFinderComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
