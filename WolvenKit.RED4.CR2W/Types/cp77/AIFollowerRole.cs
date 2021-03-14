using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerRole : AIRole
	{
		private gameEntityReference _followerRef;
		private wCHandle<gameObject> _followTarget;
		private wCHandle<gameObject> _owner;
		private CName _attitudeGroupName;
		private CArray<CName> _followTargetSquads;
		private CUInt32 _playerCombatListener;
		private EngineTime _lastStealthLeaveTimeStamp;
		private CHandle<gameAttachmentSlotsScriptListener> _friendlyTargetSlotListener;
		private CHandle<gameAttachmentSlotsScriptListener> _ownerTargetSlotListener;
		private CBool _isFriendMelee;
		private CBool _isOwnerSniper;

		[Ordinal(0)] 
		[RED("followerRef")] 
		public gameEntityReference FollowerRef
		{
			get
			{
				if (_followerRef == null)
				{
					_followerRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "followerRef", cr2w, this);
				}
				return _followerRef;
			}
			set
			{
				if (_followerRef == value)
				{
					return;
				}
				_followerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("followTarget")] 
		public wCHandle<gameObject> FollowTarget
		{
			get
			{
				if (_followTarget == null)
				{
					_followTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "followTarget", cr2w, this);
				}
				return _followTarget;
			}
			set
			{
				if (_followTarget == value)
				{
					return;
				}
				_followTarget = value;
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
		[RED("attitudeGroupName")] 
		public CName AttitudeGroupName
		{
			get
			{
				if (_attitudeGroupName == null)
				{
					_attitudeGroupName = (CName) CR2WTypeManager.Create("CName", "attitudeGroupName", cr2w, this);
				}
				return _attitudeGroupName;
			}
			set
			{
				if (_attitudeGroupName == value)
				{
					return;
				}
				_attitudeGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("followTargetSquads")] 
		public CArray<CName> FollowTargetSquads
		{
			get
			{
				if (_followTargetSquads == null)
				{
					_followTargetSquads = (CArray<CName>) CR2WTypeManager.Create("array:CName", "followTargetSquads", cr2w, this);
				}
				return _followTargetSquads;
			}
			set
			{
				if (_followTargetSquads == value)
				{
					return;
				}
				_followTargetSquads = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playerCombatListener")] 
		public CUInt32 PlayerCombatListener
		{
			get
			{
				if (_playerCombatListener == null)
				{
					_playerCombatListener = (CUInt32) CR2WTypeManager.Create("Uint32", "playerCombatListener", cr2w, this);
				}
				return _playerCombatListener;
			}
			set
			{
				if (_playerCombatListener == value)
				{
					return;
				}
				_playerCombatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lastStealthLeaveTimeStamp")] 
		public EngineTime LastStealthLeaveTimeStamp
		{
			get
			{
				if (_lastStealthLeaveTimeStamp == null)
				{
					_lastStealthLeaveTimeStamp = (EngineTime) CR2WTypeManager.Create("EngineTime", "lastStealthLeaveTimeStamp", cr2w, this);
				}
				return _lastStealthLeaveTimeStamp;
			}
			set
			{
				if (_lastStealthLeaveTimeStamp == value)
				{
					return;
				}
				_lastStealthLeaveTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("friendlyTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> FriendlyTargetSlotListener
		{
			get
			{
				if (_friendlyTargetSlotListener == null)
				{
					_friendlyTargetSlotListener = (CHandle<gameAttachmentSlotsScriptListener>) CR2WTypeManager.Create("handle:gameAttachmentSlotsScriptListener", "friendlyTargetSlotListener", cr2w, this);
				}
				return _friendlyTargetSlotListener;
			}
			set
			{
				if (_friendlyTargetSlotListener == value)
				{
					return;
				}
				_friendlyTargetSlotListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ownerTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> OwnerTargetSlotListener
		{
			get
			{
				if (_ownerTargetSlotListener == null)
				{
					_ownerTargetSlotListener = (CHandle<gameAttachmentSlotsScriptListener>) CR2WTypeManager.Create("handle:gameAttachmentSlotsScriptListener", "ownerTargetSlotListener", cr2w, this);
				}
				return _ownerTargetSlotListener;
			}
			set
			{
				if (_ownerTargetSlotListener == value)
				{
					return;
				}
				_ownerTargetSlotListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isFriendMelee")] 
		public CBool IsFriendMelee
		{
			get
			{
				if (_isFriendMelee == null)
				{
					_isFriendMelee = (CBool) CR2WTypeManager.Create("Bool", "isFriendMelee", cr2w, this);
				}
				return _isFriendMelee;
			}
			set
			{
				if (_isFriendMelee == value)
				{
					return;
				}
				_isFriendMelee = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isOwnerSniper")] 
		public CBool IsOwnerSniper
		{
			get
			{
				if (_isOwnerSniper == null)
				{
					_isOwnerSniper = (CBool) CR2WTypeManager.Create("Bool", "isOwnerSniper", cr2w, this);
				}
				return _isOwnerSniper;
			}
			set
			{
				if (_isOwnerSniper == value)
				{
					return;
				}
				_isOwnerSniper = value;
				PropertySet(this);
			}
		}

		public AIFollowerRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
