using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCrosshairBaseGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("details")] 
		public inkWidgetReference Details
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("psmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("targetBB")] 
		public CWeakHandle<gameIBlackboard> TargetBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("weaponBB")] 
		public CWeakHandle<gameIBlackboard> WeaponBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(8)] 
		[RED("targetEntity")] 
		public CWeakHandle<entEntity> TargetEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(9)] 
		[RED("raycastTargetEntity")] 
		public CWeakHandle<entEntity> RaycastTargetEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(10)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(11)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetPropertyValue<CEnum<gamePSMCrosshairStates>>();
			set => SetPropertyValue<CEnum<gamePSMCrosshairStates>>(value);
		}

		[Ordinal(12)] 
		[RED("visionState")] 
		public CEnum<gamePSMVision> VisionState
		{
			get => GetPropertyValue<CEnum<gamePSMVision>>();
			set => SetPropertyValue<CEnum<gamePSMVision>>(value);
		}

		[Ordinal(13)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("bulletSpreedBlackboardId")] 
		public CHandle<redCallbackObject> BulletSpreedBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("lastGUIStateUpdateFrame")] 
		public CUInt64 LastGUIStateUpdateFrame
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(17)] 
		[RED("currentAimTargetBBID")] 
		public CHandle<redCallbackObject> CurrentAimTargetBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("currentRaycastTargetBBID")] 
		public CHandle<redCallbackObject> CurrentRaycastTargetBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("targetDistanceBBID")] 
		public CHandle<redCallbackObject> TargetDistanceBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("targetAttitudeBBID")] 
		public CHandle<redCallbackObject> TargetAttitudeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("healthListener")] 
		public CHandle<CrosshairHealthChangeListener> HealthListener
		{
			get => GetPropertyValue<CHandle<CrosshairHealthChangeListener>>();
			set => SetPropertyValue<CHandle<CrosshairHealthChangeListener>>(value);
		}

		[Ordinal(22)] 
		[RED("deadEyeWidget")] 
		public inkWidgetReference DeadEyeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("deadEyeAnimProxy")] 
		public CHandle<inkanimProxy> DeadEyeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("hasDeadEye")] 
		public CBool HasDeadEye
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("staminaChangedCallback")] 
		public CHandle<redCallbackObject> StaminaChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("staminaListener")] 
		public CHandle<CrosshairStaminaListener> StaminaListener
		{
			get => GetPropertyValue<CHandle<CrosshairStaminaListener>>();
			set => SetPropertyValue<CHandle<CrosshairStaminaListener>>(value);
		}

		public gameuiCrosshairBaseGameController()
		{
			Details = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
