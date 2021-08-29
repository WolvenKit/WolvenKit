using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFollowerRole : AIRole
	{
		private gameEntityReference _followerRef;
		private CWeakHandle<gameObject> _followTarget;
		private CWeakHandle<gameObject> _owner;
		private CName _attitudeGroupName;
		private CArray<CName> _followTargetSquads;
		private CHandle<redCallbackObject> _playerCombatListener;
		private EngineTime _lastStealthLeaveTimeStamp;
		private CHandle<gameAttachmentSlotsScriptListener> _friendlyTargetSlotListener;
		private CHandle<gameAttachmentSlotsScriptListener> _ownerTargetSlotListener;
		private CBool _isFriendMelee;
		private CBool _isOwnerSniper;

		[Ordinal(0)] 
		[RED("followerRef")] 
		public gameEntityReference FollowerRef
		{
			get => GetProperty(ref _followerRef);
			set => SetProperty(ref _followerRef, value);
		}

		[Ordinal(1)] 
		[RED("followTarget")] 
		public CWeakHandle<gameObject> FollowTarget
		{
			get => GetProperty(ref _followTarget);
			set => SetProperty(ref _followTarget, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("attitudeGroupName")] 
		public CName AttitudeGroupName
		{
			get => GetProperty(ref _attitudeGroupName);
			set => SetProperty(ref _attitudeGroupName, value);
		}

		[Ordinal(4)] 
		[RED("followTargetSquads")] 
		public CArray<CName> FollowTargetSquads
		{
			get => GetProperty(ref _followTargetSquads);
			set => SetProperty(ref _followTargetSquads, value);
		}

		[Ordinal(5)] 
		[RED("playerCombatListener")] 
		public CHandle<redCallbackObject> PlayerCombatListener
		{
			get => GetProperty(ref _playerCombatListener);
			set => SetProperty(ref _playerCombatListener, value);
		}

		[Ordinal(6)] 
		[RED("lastStealthLeaveTimeStamp")] 
		public EngineTime LastStealthLeaveTimeStamp
		{
			get => GetProperty(ref _lastStealthLeaveTimeStamp);
			set => SetProperty(ref _lastStealthLeaveTimeStamp, value);
		}

		[Ordinal(7)] 
		[RED("friendlyTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> FriendlyTargetSlotListener
		{
			get => GetProperty(ref _friendlyTargetSlotListener);
			set => SetProperty(ref _friendlyTargetSlotListener, value);
		}

		[Ordinal(8)] 
		[RED("ownerTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> OwnerTargetSlotListener
		{
			get => GetProperty(ref _ownerTargetSlotListener);
			set => SetProperty(ref _ownerTargetSlotListener, value);
		}

		[Ordinal(9)] 
		[RED("isFriendMelee")] 
		public CBool IsFriendMelee
		{
			get => GetProperty(ref _isFriendMelee);
			set => SetProperty(ref _isFriendMelee, value);
		}

		[Ordinal(10)] 
		[RED("isOwnerSniper")] 
		public CBool IsOwnerSniper
		{
			get => GetProperty(ref _isOwnerSniper);
			set => SetProperty(ref _isOwnerSniper, value);
		}
	}
}
