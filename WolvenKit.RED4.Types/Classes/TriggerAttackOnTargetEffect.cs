using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerAttackOnTargetEffect : gameEffector
	{
		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetPropertyValue<CHandle<gameAttack_GameEffect>>();
			set => SetPropertyValue<CHandle<gameAttack_GameEffect>>(value);
		}

		public TriggerAttackOnTargetEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
