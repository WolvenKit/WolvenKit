using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnOwnerEffect : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CBool _playerAsInstigator;
		private CBool _triggerHitReaction;
		private CName _attackPositionSlotName;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("playerAsInstigator")] 
		public CBool PlayerAsInstigator
		{
			get
			{
				if (_playerAsInstigator == null)
				{
					_playerAsInstigator = (CBool) CR2WTypeManager.Create("Bool", "playerAsInstigator", cr2w, this);
				}
				return _playerAsInstigator;
			}
			set
			{
				if (_playerAsInstigator == value)
				{
					return;
				}
				_playerAsInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("triggerHitReaction")] 
		public CBool TriggerHitReaction
		{
			get
			{
				if (_triggerHitReaction == null)
				{
					_triggerHitReaction = (CBool) CR2WTypeManager.Create("Bool", "triggerHitReaction", cr2w, this);
				}
				return _triggerHitReaction;
			}
			set
			{
				if (_triggerHitReaction == value)
				{
					return;
				}
				_triggerHitReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attackPositionSlotName")] 
		public CName AttackPositionSlotName
		{
			get
			{
				if (_attackPositionSlotName == null)
				{
					_attackPositionSlotName = (CName) CR2WTypeManager.Create("CName", "attackPositionSlotName", cr2w, this);
				}
				return _attackPositionSlotName;
			}
			set
			{
				if (_attackPositionSlotName == value)
				{
					return;
				}
				_attackPositionSlotName = value;
				PropertySet(this);
			}
		}

		public TriggerAttackOnOwnerEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
