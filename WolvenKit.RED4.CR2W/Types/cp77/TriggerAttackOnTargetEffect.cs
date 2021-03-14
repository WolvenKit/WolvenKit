using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnTargetEffect : gameEffector
	{
		private CBool _isRandom;
		private CFloat _applicationChance;
		private wCHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CHandle<gameAttack_GameEffect> _attack;

		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get
			{
				if (_isRandom == null)
				{
					_isRandom = (CBool) CR2WTypeManager.Create("Bool", "isRandom", cr2w, this);
				}
				return _isRandom;
			}
			set
			{
				if (_isRandom == value)
				{
					return;
				}
				_isRandom = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get
			{
				if (_applicationChance == null)
				{
					_applicationChance = (CFloat) CR2WTypeManager.Create("Float", "applicationChance", cr2w, this);
				}
				return _applicationChance;
			}
			set
			{
				if (_applicationChance == value)
				{
					return;
				}
				_applicationChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get
			{
				if (_attackTDBID == null)
				{
					_attackTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackTDBID", cr2w, this);
				}
				return _attackTDBID;
			}
			set
			{
				if (_attackTDBID == value)
				{
					return;
				}
				_attackTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get
			{
				if (_attack == null)
				{
					_attack = (CHandle<gameAttack_GameEffect>) CR2WTypeManager.Create("handle:gameAttack_GameEffect", "attack", cr2w, this);
				}
				return _attack;
			}
			set
			{
				if (_attack == value)
				{
					return;
				}
				_attack = value;
				PropertySet(this);
			}
		}

		public TriggerAttackOnTargetEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
