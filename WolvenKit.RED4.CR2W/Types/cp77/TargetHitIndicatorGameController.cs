using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetHitIndicatorGameController : gameuiWidgetGameController
	{
		private CHandle<inkanimProxy> _currentAnim;
		private CHandle<inkanimProxy> _bonusAnim;
		private wCHandle<inkWidget> _currentAnimWidget;
		private CInt32 _currentPriority;
		private wCHandle<TargetHitIndicatorLogicController> _currentController;
		private wCHandle<TargetHitIndicatorLogicController> _damageController;
		private wCHandle<TargetHitIndicatorLogicController> _defeatController;
		private wCHandle<TargetHitIndicatorLogicController> _killController;
		private wCHandle<TargetHitIndicatorLogicController> _bonusController;
		private CHandle<redCallbackObject> _damageListBlackboardId;
		private CHandle<redCallbackObject> _killListBlackboardId;
		private CHandle<redCallbackObject> _indicatorEnabledBlackboardId;
		private CHandle<redCallbackObject> _weaponSwayBlackboardId;
		private CHandle<redCallbackObject> _weaponChangeBlackboardId;
		private CHandle<redCallbackObject> _aimingStatusBlackboardId;
		private CHandle<redCallbackObject> _zoomLevelBlackboardId;
		private wCHandle<gameObject> _realOwner;
		private CBool _hitIndicatorEnabled;
		private wCHandle<gameObject> _entityHit;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<PlayerPuppet> _player;
		private Vector2 _currentSway;
		private CFloat _currentWeaponZoom;
		private CBool _weaponZoomNeedsUpdate;
		private CFloat _currentZoomLevel;
		private CHandle<HitIndicatorWeaponZoomListener> _weaponZoomListener;
		private gameStatsObjectID _weaponID;
		private CBool _isAimingDownSights;

		[Ordinal(2)] 
		[RED("currentAnim")] 
		public CHandle<inkanimProxy> CurrentAnim
		{
			get => GetProperty(ref _currentAnim);
			set => SetProperty(ref _currentAnim, value);
		}

		[Ordinal(3)] 
		[RED("bonusAnim")] 
		public CHandle<inkanimProxy> BonusAnim
		{
			get => GetProperty(ref _bonusAnim);
			set => SetProperty(ref _bonusAnim, value);
		}

		[Ordinal(4)] 
		[RED("currentAnimWidget")] 
		public wCHandle<inkWidget> CurrentAnimWidget
		{
			get => GetProperty(ref _currentAnimWidget);
			set => SetProperty(ref _currentAnimWidget, value);
		}

		[Ordinal(5)] 
		[RED("currentPriority")] 
		public CInt32 CurrentPriority
		{
			get => GetProperty(ref _currentPriority);
			set => SetProperty(ref _currentPriority, value);
		}

		[Ordinal(6)] 
		[RED("currentController")] 
		public wCHandle<TargetHitIndicatorLogicController> CurrentController
		{
			get => GetProperty(ref _currentController);
			set => SetProperty(ref _currentController, value);
		}

		[Ordinal(7)] 
		[RED("damageController")] 
		public wCHandle<TargetHitIndicatorLogicController> DamageController
		{
			get => GetProperty(ref _damageController);
			set => SetProperty(ref _damageController, value);
		}

		[Ordinal(8)] 
		[RED("defeatController")] 
		public wCHandle<TargetHitIndicatorLogicController> DefeatController
		{
			get => GetProperty(ref _defeatController);
			set => SetProperty(ref _defeatController, value);
		}

		[Ordinal(9)] 
		[RED("killController")] 
		public wCHandle<TargetHitIndicatorLogicController> KillController
		{
			get => GetProperty(ref _killController);
			set => SetProperty(ref _killController, value);
		}

		[Ordinal(10)] 
		[RED("bonusController")] 
		public wCHandle<TargetHitIndicatorLogicController> BonusController
		{
			get => GetProperty(ref _bonusController);
			set => SetProperty(ref _bonusController, value);
		}

		[Ordinal(11)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetProperty(ref _damageListBlackboardId);
			set => SetProperty(ref _damageListBlackboardId, value);
		}

		[Ordinal(12)] 
		[RED("killListBlackboardId")] 
		public CHandle<redCallbackObject> KillListBlackboardId
		{
			get => GetProperty(ref _killListBlackboardId);
			set => SetProperty(ref _killListBlackboardId, value);
		}

		[Ordinal(13)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CHandle<redCallbackObject> IndicatorEnabledBlackboardId
		{
			get => GetProperty(ref _indicatorEnabledBlackboardId);
			set => SetProperty(ref _indicatorEnabledBlackboardId, value);
		}

		[Ordinal(14)] 
		[RED("weaponSwayBlackboardId")] 
		public CHandle<redCallbackObject> WeaponSwayBlackboardId
		{
			get => GetProperty(ref _weaponSwayBlackboardId);
			set => SetProperty(ref _weaponSwayBlackboardId, value);
		}

		[Ordinal(15)] 
		[RED("weaponChangeBlackboardId")] 
		public CHandle<redCallbackObject> WeaponChangeBlackboardId
		{
			get => GetProperty(ref _weaponChangeBlackboardId);
			set => SetProperty(ref _weaponChangeBlackboardId, value);
		}

		[Ordinal(16)] 
		[RED("aimingStatusBlackboardId")] 
		public CHandle<redCallbackObject> AimingStatusBlackboardId
		{
			get => GetProperty(ref _aimingStatusBlackboardId);
			set => SetProperty(ref _aimingStatusBlackboardId, value);
		}

		[Ordinal(17)] 
		[RED("zoomLevelBlackboardId")] 
		public CHandle<redCallbackObject> ZoomLevelBlackboardId
		{
			get => GetProperty(ref _zoomLevelBlackboardId);
			set => SetProperty(ref _zoomLevelBlackboardId, value);
		}

		[Ordinal(18)] 
		[RED("realOwner")] 
		public wCHandle<gameObject> RealOwner
		{
			get => GetProperty(ref _realOwner);
			set => SetProperty(ref _realOwner, value);
		}

		[Ordinal(19)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetProperty(ref _hitIndicatorEnabled);
			set => SetProperty(ref _hitIndicatorEnabled, value);
		}

		[Ordinal(20)] 
		[RED("entityHit")] 
		public wCHandle<gameObject> EntityHit
		{
			get => GetProperty(ref _entityHit);
			set => SetProperty(ref _entityHit, value);
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(22)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(23)] 
		[RED("currentSway")] 
		public Vector2 CurrentSway
		{
			get => GetProperty(ref _currentSway);
			set => SetProperty(ref _currentSway, value);
		}

		[Ordinal(24)] 
		[RED("currentWeaponZoom")] 
		public CFloat CurrentWeaponZoom
		{
			get => GetProperty(ref _currentWeaponZoom);
			set => SetProperty(ref _currentWeaponZoom, value);
		}

		[Ordinal(25)] 
		[RED("weaponZoomNeedsUpdate")] 
		public CBool WeaponZoomNeedsUpdate
		{
			get => GetProperty(ref _weaponZoomNeedsUpdate);
			set => SetProperty(ref _weaponZoomNeedsUpdate, value);
		}

		[Ordinal(26)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetProperty(ref _currentZoomLevel);
			set => SetProperty(ref _currentZoomLevel, value);
		}

		[Ordinal(27)] 
		[RED("weaponZoomListener")] 
		public CHandle<HitIndicatorWeaponZoomListener> WeaponZoomListener
		{
			get => GetProperty(ref _weaponZoomListener);
			set => SetProperty(ref _weaponZoomListener, value);
		}

		[Ordinal(28)] 
		[RED("weaponID")] 
		public gameStatsObjectID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(29)] 
		[RED("isAimingDownSights")] 
		public CBool IsAimingDownSights
		{
			get => GetProperty(ref _isAimingDownSights);
			set => SetProperty(ref _isAimingDownSights, value);
		}

		public TargetHitIndicatorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
