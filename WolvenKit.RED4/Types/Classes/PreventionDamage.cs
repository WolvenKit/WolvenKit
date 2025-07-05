using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionDamage : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(3)] 
		[RED("damageDealtPercent")] 
		public CFloat DamageDealtPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("isTargetKilled")] 
		public CBool IsTargetKilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionDamage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
