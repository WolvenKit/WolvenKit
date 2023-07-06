using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedamageAttackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(4)] 
		[RED("attackDefinition")] 
		public CHandle<gameIAttack> AttackDefinition
		{
			get => GetPropertyValue<CHandle<gameIAttack>>();
			set => SetPropertyValue<CHandle<gameIAttack>>(value);
		}

		[Ordinal(5)] 
		[RED("attackPosition")] 
		public Vector4 AttackPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("weaponCharge")] 
		public CFloat WeaponCharge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get => GetPropertyValue<CArray<SHitFlag>>();
			set => SetPropertyValue<CArray<SHitFlag>>(value);
		}

		[Ordinal(10)] 
		[RED("statusEffects")] 
		public CArray<SHitStatusEffect> StatusEffects
		{
			get => GetPropertyValue<CArray<SHitStatusEffect>>();
			set => SetPropertyValue<CArray<SHitStatusEffect>>(value);
		}

		[Ordinal(11)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetPropertyValue<CEnum<gameuiHitType>>();
			set => SetPropertyValue<CEnum<gameuiHitType>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleImpactForce")] 
		public CFloat VehicleImpactForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("additionalCritChance")] 
		public CFloat AdditionalCritChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamedamageAttackData()
		{
			AttackPosition = new Vector4();
			Flags = new();
			StatusEffects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
