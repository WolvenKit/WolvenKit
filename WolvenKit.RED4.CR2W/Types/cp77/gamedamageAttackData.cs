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
			get
			{
				if (_attackType == null)
				{
					_attackType = (CEnum<gamedataAttackType>) CR2WTypeManager.Create("gamedataAttackType", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attackDefinition")] 
		public CHandle<gameIAttack> AttackDefinition
		{
			get
			{
				if (_attackDefinition == null)
				{
					_attackDefinition = (CHandle<gameIAttack>) CR2WTypeManager.Create("handle:gameIAttack", "attackDefinition", cr2w, this);
				}
				return _attackDefinition;
			}
			set
			{
				if (_attackDefinition == value)
				{
					return;
				}
				_attackDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attackPosition")] 
		public Vector4 AttackPosition
		{
			get
			{
				if (_attackPosition == null)
				{
					_attackPosition = (Vector4) CR2WTypeManager.Create("Vector4", "attackPosition", cr2w, this);
				}
				return _attackPosition;
			}
			set
			{
				if (_attackPosition == value)
				{
					return;
				}
				_attackPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("weaponCharge")] 
		public CFloat WeaponCharge
		{
			get
			{
				if (_weaponCharge == null)
				{
					_weaponCharge = (CFloat) CR2WTypeManager.Create("Float", "weaponCharge", cr2w, this);
				}
				return _weaponCharge;
			}
			set
			{
				if (_weaponCharge == value)
				{
					return;
				}
				_weaponCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get
			{
				if (_numRicochetBounces == null)
				{
					_numRicochetBounces = (CInt32) CR2WTypeManager.Create("Int32", "numRicochetBounces", cr2w, this);
				}
				return _numRicochetBounces;
			}
			set
			{
				if (_numRicochetBounces == value)
				{
					return;
				}
				_numRicochetBounces = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CArray<SHitFlag>) CR2WTypeManager.Create("array:SHitFlag", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statusEffects")] 
		public CArray<SHitStatusEffect> StatusEffects
		{
			get
			{
				if (_statusEffects == null)
				{
					_statusEffects = (CArray<SHitStatusEffect>) CR2WTypeManager.Create("array:SHitStatusEffect", "statusEffects", cr2w, this);
				}
				return _statusEffects;
			}
			set
			{
				if (_statusEffects == value)
				{
					return;
				}
				_statusEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CEnum<gameuiHitType>) CR2WTypeManager.Create("gameuiHitType", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehicleImpactForce")] 
		public CFloat VehicleImpactForce
		{
			get
			{
				if (_vehicleImpactForce == null)
				{
					_vehicleImpactForce = (CFloat) CR2WTypeManager.Create("Float", "vehicleImpactForce", cr2w, this);
				}
				return _vehicleImpactForce;
			}
			set
			{
				if (_vehicleImpactForce == value)
				{
					return;
				}
				_vehicleImpactForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("additionalCritChance")] 
		public CFloat AdditionalCritChance
		{
			get
			{
				if (_additionalCritChance == null)
				{
					_additionalCritChance = (CFloat) CR2WTypeManager.Create("Float", "additionalCritChance", cr2w, this);
				}
				return _additionalCritChance;
			}
			set
			{
				if (_additionalCritChance == value)
				{
					return;
				}
				_additionalCritChance = value;
				PropertySet(this);
			}
		}

		public gamedamageAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
