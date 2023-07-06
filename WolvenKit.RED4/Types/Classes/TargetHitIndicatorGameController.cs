using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetHitIndicatorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("currentAnim")] 
		public CHandle<inkanimProxy> CurrentAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(3)] 
		[RED("bonusAnim")] 
		public CHandle<inkanimProxy> BonusAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("currentAnimWidget")] 
		public CWeakHandle<inkWidget> CurrentAnimWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("currentPriority")] 
		public CInt32 CurrentPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("currentController")] 
		public CWeakHandle<TargetHitIndicatorLogicController> CurrentController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>(value);
		}

		[Ordinal(7)] 
		[RED("damageController")] 
		public CWeakHandle<TargetHitIndicatorLogicController> DamageController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>(value);
		}

		[Ordinal(8)] 
		[RED("defeatController")] 
		public CWeakHandle<TargetHitIndicatorLogicController> DefeatController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>(value);
		}

		[Ordinal(9)] 
		[RED("killController")] 
		public CWeakHandle<TargetHitIndicatorLogicController> KillController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>(value);
		}

		[Ordinal(10)] 
		[RED("bonusController")] 
		public CWeakHandle<TargetHitIndicatorLogicController> BonusController
		{
			get => GetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>();
			set => SetPropertyValue<CWeakHandle<TargetHitIndicatorLogicController>>(value);
		}

		[Ordinal(11)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("killListBlackboardId")] 
		public CHandle<redCallbackObject> KillListBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CHandle<redCallbackObject> IndicatorEnabledBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("weaponSwayBlackboardId")] 
		public CHandle<redCallbackObject> WeaponSwayBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("weaponChangeBlackboardId")] 
		public CHandle<redCallbackObject> WeaponChangeBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("aimingStatusBlackboardId")] 
		public CHandle<redCallbackObject> AimingStatusBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("zoomLevelBlackboardId")] 
		public CHandle<redCallbackObject> ZoomLevelBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("realOwner")] 
		public CWeakHandle<gameObject> RealOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(19)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("entityHit")] 
		public CWeakHandle<gameObject> EntityHit
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(23)] 
		[RED("currentSway")] 
		public Vector2 CurrentSway
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(24)] 
		[RED("currentWeaponZoom")] 
		public CFloat CurrentWeaponZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("weaponZoomNeedsUpdate")] 
		public CBool WeaponZoomNeedsUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("weaponZoomListener")] 
		public CHandle<HitIndicatorWeaponZoomListener> WeaponZoomListener
		{
			get => GetPropertyValue<CHandle<HitIndicatorWeaponZoomListener>>();
			set => SetPropertyValue<CHandle<HitIndicatorWeaponZoomListener>>(value);
		}

		[Ordinal(28)] 
		[RED("weaponID")] 
		public gameStatsObjectID WeaponID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		[Ordinal(29)] 
		[RED("isAimingDownSights")] 
		public CBool IsAimingDownSights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TargetHitIndicatorGameController()
		{
			CurrentSway = new Vector2();
			WeaponID = new gameStatsObjectID { IdType = Enums.gameStatIDType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
