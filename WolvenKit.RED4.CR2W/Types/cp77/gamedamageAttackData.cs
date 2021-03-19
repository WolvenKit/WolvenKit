using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageAttackData : IScriptable
	{
		private CEnum<gamedataAttackType> _attackType;
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _source;
		private wCHandle<gameweaponObject> _weapon;
		private CHandle<gameIAttack> _attackDefinition;
		private Vector4 _attackPosition;
		private CFloat _weaponCharge;
		private CInt32 _numRicochetBounces;
		private CArray<SHitFlag> _flags;
		private CArray<SHitStatusEffect> _statusEffects;
		private CEnum<gameuiHitType> _hitType;
		private CFloat _vehicleImpactForce;
		private CFloat _additionalCritChance;

		[Ordinal(0)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(2)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(4)] 
		[RED("attackDefinition")] 
		public CHandle<gameIAttack> AttackDefinition
		{
			get => GetProperty(ref _attackDefinition);
			set => SetProperty(ref _attackDefinition, value);
		}

		[Ordinal(5)] 
		[RED("attackPosition")] 
		public Vector4 AttackPosition
		{
			get => GetProperty(ref _attackPosition);
			set => SetProperty(ref _attackPosition, value);
		}

		[Ordinal(6)] 
		[RED("weaponCharge")] 
		public CFloat WeaponCharge
		{
			get => GetProperty(ref _weaponCharge);
			set => SetProperty(ref _weaponCharge, value);
		}

		[Ordinal(7)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get => GetProperty(ref _numRicochetBounces);
			set => SetProperty(ref _numRicochetBounces, value);
		}

		[Ordinal(8)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(9)] 
		[RED("statusEffects")] 
		public CArray<SHitStatusEffect> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}

		[Ordinal(10)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(11)] 
		[RED("vehicleImpactForce")] 
		public CFloat VehicleImpactForce
		{
			get => GetProperty(ref _vehicleImpactForce);
			set => SetProperty(ref _vehicleImpactForce, value);
		}

		[Ordinal(12)] 
		[RED("additionalCritChance")] 
		public CFloat AdditionalCritChance
		{
			get => GetProperty(ref _additionalCritChance);
			set => SetProperty(ref _additionalCritChance, value);
		}

		public gamedamageAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
