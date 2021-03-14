using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsHitEvent : redEvent
	{
		private CEnum<gamedataAttackType> _attackType;
		private Vector4 _hitPosition;
		private CName _physicsMaterial;
		private CFloat _damage;
		private CBool _isTargetPuppet;
		private CName _targetPuppetMeleeMaterial;

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
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "hitPosition", cr2w, this);
				}
				return _hitPosition;
			}
			set
			{
				if (_hitPosition == value)
				{
					return;
				}
				_hitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get
			{
				if (_physicsMaterial == null)
				{
					_physicsMaterial = (CName) CR2WTypeManager.Create("CName", "physicsMaterial", cr2w, this);
				}
				return _physicsMaterial;
			}
			set
			{
				if (_physicsMaterial == value)
				{
					return;
				}
				_physicsMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("damage")] 
		public CFloat Damage
		{
			get
			{
				if (_damage == null)
				{
					_damage = (CFloat) CR2WTypeManager.Create("Float", "damage", cr2w, this);
				}
				return _damage;
			}
			set
			{
				if (_damage == value)
				{
					return;
				}
				_damage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isTargetPuppet")] 
		public CBool IsTargetPuppet
		{
			get
			{
				if (_isTargetPuppet == null)
				{
					_isTargetPuppet = (CBool) CR2WTypeManager.Create("Bool", "isTargetPuppet", cr2w, this);
				}
				return _isTargetPuppet;
			}
			set
			{
				if (_isTargetPuppet == value)
				{
					return;
				}
				_isTargetPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetPuppetMeleeMaterial")] 
		public CName TargetPuppetMeleeMaterial
		{
			get
			{
				if (_targetPuppetMeleeMaterial == null)
				{
					_targetPuppetMeleeMaterial = (CName) CR2WTypeManager.Create("CName", "targetPuppetMeleeMaterial", cr2w, this);
				}
				return _targetPuppetMeleeMaterial;
			}
			set
			{
				if (_targetPuppetMeleeMaterial == value)
				{
					return;
				}
				_targetPuppetMeleeMaterial = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
