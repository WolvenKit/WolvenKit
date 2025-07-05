using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerContinuousAttackEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetPropertyValue<CHandle<gameAttack_GameEffect>>();
			set => SetPropertyValue<CHandle<gameAttack_GameEffect>>(value);
		}

		[Ordinal(3)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("timeDilationDriver")] 
		public CEnum<gamedataEffectorTimeDilationDriver> TimeDilationDriver
		{
			get => GetPropertyValue<CEnum<gamedataEffectorTimeDilationDriver>>();
			set => SetPropertyValue<CEnum<gamedataEffectorTimeDilationDriver>>(value);
		}

		public TriggerContinuousAttackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
