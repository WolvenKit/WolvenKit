using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryDamage : CVariable
	{
		private CEnum<gamedataAttackType> _attackType;
		private CFloat _damageAmount;
		private gameTelemetryInventoryItem _weapon;
		private CUInt32 _hitCount;
		private CFloat _distance;
		private CFloat _time;

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
		[RED("damageAmount")] 
		public CFloat DamageAmount
		{
			get
			{
				if (_damageAmount == null)
				{
					_damageAmount = (CFloat) CR2WTypeManager.Create("Float", "damageAmount", cr2w, this);
				}
				return _damageAmount;
			}
			set
			{
				if (_damageAmount == value)
				{
					return;
				}
				_damageAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public gameTelemetryInventoryItem Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (gameTelemetryInventoryItem) CR2WTypeManager.Create("gameTelemetryInventoryItem", "weapon", cr2w, this);
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

		[Ordinal(3)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get
			{
				if (_hitCount == null)
				{
					_hitCount = (CUInt32) CR2WTypeManager.Create("Uint32", "hitCount", cr2w, this);
				}
				return _hitCount;
			}
			set
			{
				if (_hitCount == value)
				{
					return;
				}
				_hitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public gameTelemetryDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
