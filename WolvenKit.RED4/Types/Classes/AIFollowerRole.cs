using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFollowerRole : AIRole
	{
		[Ordinal(0)] 
		[RED("followerRef")] 
		public gameEntityReference FollowerRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("followTarget")] 
		public CWeakHandle<gameObject> FollowTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("attitudeGroupName")] 
		public CName AttitudeGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("followTargetSquads")] 
		public CArray<CName> FollowTargetSquads
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("playerCombatListener")] 
		public CHandle<redCallbackObject> PlayerCombatListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("lastStealthLeaveTimeStamp")] 
		public EngineTime LastStealthLeaveTimeStamp
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(7)] 
		[RED("friendlyTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> FriendlyTargetSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(8)] 
		[RED("ownerTargetSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> OwnerTargetSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(9)] 
		[RED("isFriendMelee")] 
		public CBool IsFriendMelee
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isOwnerSniper")] 
		public CBool IsOwnerSniper
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIFollowerRole()
		{
			FollowerRef = new gameEntityReference { Names = new() };
			FollowTargetSquads = new();
			LastStealthLeaveTimeStamp = new EngineTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
