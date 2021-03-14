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
		private CUInt32 _damageListBlackboardId;
		private CUInt32 _killListBlackboardId;
		private CUInt32 _indicatorEnabledBlackboardId;
		private CUInt32 _weaponSwayBlackboardId;
		private CUInt32 _weaponChangeBlackboardId;
		private CUInt32 _aimingStatusBlackboardId;
		private CUInt32 _zoomLevelBlackboardId;
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
			get
			{
				if (_currentAnim == null)
				{
					_currentAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "currentAnim", cr2w, this);
				}
				return _currentAnim;
			}
			set
			{
				if (_currentAnim == value)
				{
					return;
				}
				_currentAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bonusAnim")] 
		public CHandle<inkanimProxy> BonusAnim
		{
			get
			{
				if (_bonusAnim == null)
				{
					_bonusAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "bonusAnim", cr2w, this);
				}
				return _bonusAnim;
			}
			set
			{
				if (_bonusAnim == value)
				{
					return;
				}
				_bonusAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentAnimWidget")] 
		public wCHandle<inkWidget> CurrentAnimWidget
		{
			get
			{
				if (_currentAnimWidget == null)
				{
					_currentAnimWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "currentAnimWidget", cr2w, this);
				}
				return _currentAnimWidget;
			}
			set
			{
				if (_currentAnimWidget == value)
				{
					return;
				}
				_currentAnimWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentPriority")] 
		public CInt32 CurrentPriority
		{
			get
			{
				if (_currentPriority == null)
				{
					_currentPriority = (CInt32) CR2WTypeManager.Create("Int32", "currentPriority", cr2w, this);
				}
				return _currentPriority;
			}
			set
			{
				if (_currentPriority == value)
				{
					return;
				}
				_currentPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentController")] 
		public wCHandle<TargetHitIndicatorLogicController> CurrentController
		{
			get
			{
				if (_currentController == null)
				{
					_currentController = (wCHandle<TargetHitIndicatorLogicController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorLogicController", "currentController", cr2w, this);
				}
				return _currentController;
			}
			set
			{
				if (_currentController == value)
				{
					return;
				}
				_currentController = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("damageController")] 
		public wCHandle<TargetHitIndicatorLogicController> DamageController
		{
			get
			{
				if (_damageController == null)
				{
					_damageController = (wCHandle<TargetHitIndicatorLogicController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorLogicController", "damageController", cr2w, this);
				}
				return _damageController;
			}
			set
			{
				if (_damageController == value)
				{
					return;
				}
				_damageController = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("defeatController")] 
		public wCHandle<TargetHitIndicatorLogicController> DefeatController
		{
			get
			{
				if (_defeatController == null)
				{
					_defeatController = (wCHandle<TargetHitIndicatorLogicController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorLogicController", "defeatController", cr2w, this);
				}
				return _defeatController;
			}
			set
			{
				if (_defeatController == value)
				{
					return;
				}
				_defeatController = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("killController")] 
		public wCHandle<TargetHitIndicatorLogicController> KillController
		{
			get
			{
				if (_killController == null)
				{
					_killController = (wCHandle<TargetHitIndicatorLogicController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorLogicController", "killController", cr2w, this);
				}
				return _killController;
			}
			set
			{
				if (_killController == value)
				{
					return;
				}
				_killController = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bonusController")] 
		public wCHandle<TargetHitIndicatorLogicController> BonusController
		{
			get
			{
				if (_bonusController == null)
				{
					_bonusController = (wCHandle<TargetHitIndicatorLogicController>) CR2WTypeManager.Create("whandle:TargetHitIndicatorLogicController", "bonusController", cr2w, this);
				}
				return _bonusController;
			}
			set
			{
				if (_bonusController == value)
				{
					return;
				}
				_bonusController = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("damageListBlackboardId")] 
		public CUInt32 DamageListBlackboardId
		{
			get
			{
				if (_damageListBlackboardId == null)
				{
					_damageListBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "damageListBlackboardId", cr2w, this);
				}
				return _damageListBlackboardId;
			}
			set
			{
				if (_damageListBlackboardId == value)
				{
					return;
				}
				_damageListBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("killListBlackboardId")] 
		public CUInt32 KillListBlackboardId
		{
			get
			{
				if (_killListBlackboardId == null)
				{
					_killListBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "killListBlackboardId", cr2w, this);
				}
				return _killListBlackboardId;
			}
			set
			{
				if (_killListBlackboardId == value)
				{
					return;
				}
				_killListBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CUInt32 IndicatorEnabledBlackboardId
		{
			get
			{
				if (_indicatorEnabledBlackboardId == null)
				{
					_indicatorEnabledBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "indicatorEnabledBlackboardId", cr2w, this);
				}
				return _indicatorEnabledBlackboardId;
			}
			set
			{
				if (_indicatorEnabledBlackboardId == value)
				{
					return;
				}
				_indicatorEnabledBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("weaponSwayBlackboardId")] 
		public CUInt32 WeaponSwayBlackboardId
		{
			get
			{
				if (_weaponSwayBlackboardId == null)
				{
					_weaponSwayBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponSwayBlackboardId", cr2w, this);
				}
				return _weaponSwayBlackboardId;
			}
			set
			{
				if (_weaponSwayBlackboardId == value)
				{
					return;
				}
				_weaponSwayBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("weaponChangeBlackboardId")] 
		public CUInt32 WeaponChangeBlackboardId
		{
			get
			{
				if (_weaponChangeBlackboardId == null)
				{
					_weaponChangeBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponChangeBlackboardId", cr2w, this);
				}
				return _weaponChangeBlackboardId;
			}
			set
			{
				if (_weaponChangeBlackboardId == value)
				{
					return;
				}
				_weaponChangeBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("aimingStatusBlackboardId")] 
		public CUInt32 AimingStatusBlackboardId
		{
			get
			{
				if (_aimingStatusBlackboardId == null)
				{
					_aimingStatusBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "aimingStatusBlackboardId", cr2w, this);
				}
				return _aimingStatusBlackboardId;
			}
			set
			{
				if (_aimingStatusBlackboardId == value)
				{
					return;
				}
				_aimingStatusBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("zoomLevelBlackboardId")] 
		public CUInt32 ZoomLevelBlackboardId
		{
			get
			{
				if (_zoomLevelBlackboardId == null)
				{
					_zoomLevelBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "zoomLevelBlackboardId", cr2w, this);
				}
				return _zoomLevelBlackboardId;
			}
			set
			{
				if (_zoomLevelBlackboardId == value)
				{
					return;
				}
				_zoomLevelBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("realOwner")] 
		public wCHandle<gameObject> RealOwner
		{
			get
			{
				if (_realOwner == null)
				{
					_realOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "realOwner", cr2w, this);
				}
				return _realOwner;
			}
			set
			{
				if (_realOwner == value)
				{
					return;
				}
				_realOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get
			{
				if (_hitIndicatorEnabled == null)
				{
					_hitIndicatorEnabled = (CBool) CR2WTypeManager.Create("Bool", "hitIndicatorEnabled", cr2w, this);
				}
				return _hitIndicatorEnabled;
			}
			set
			{
				if (_hitIndicatorEnabled == value)
				{
					return;
				}
				_hitIndicatorEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("entityHit")] 
		public wCHandle<gameObject> EntityHit
		{
			get
			{
				if (_entityHit == null)
				{
					_entityHit = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "entityHit", cr2w, this);
				}
				return _entityHit;
			}
			set
			{
				if (_entityHit == value)
				{
					return;
				}
				_entityHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentSway")] 
		public Vector2 CurrentSway
		{
			get
			{
				if (_currentSway == null)
				{
					_currentSway = (Vector2) CR2WTypeManager.Create("Vector2", "currentSway", cr2w, this);
				}
				return _currentSway;
			}
			set
			{
				if (_currentSway == value)
				{
					return;
				}
				_currentSway = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("currentWeaponZoom")] 
		public CFloat CurrentWeaponZoom
		{
			get
			{
				if (_currentWeaponZoom == null)
				{
					_currentWeaponZoom = (CFloat) CR2WTypeManager.Create("Float", "currentWeaponZoom", cr2w, this);
				}
				return _currentWeaponZoom;
			}
			set
			{
				if (_currentWeaponZoom == value)
				{
					return;
				}
				_currentWeaponZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("weaponZoomNeedsUpdate")] 
		public CBool WeaponZoomNeedsUpdate
		{
			get
			{
				if (_weaponZoomNeedsUpdate == null)
				{
					_weaponZoomNeedsUpdate = (CBool) CR2WTypeManager.Create("Bool", "weaponZoomNeedsUpdate", cr2w, this);
				}
				return _weaponZoomNeedsUpdate;
			}
			set
			{
				if (_weaponZoomNeedsUpdate == value)
				{
					return;
				}
				_weaponZoomNeedsUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get
			{
				if (_currentZoomLevel == null)
				{
					_currentZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "currentZoomLevel", cr2w, this);
				}
				return _currentZoomLevel;
			}
			set
			{
				if (_currentZoomLevel == value)
				{
					return;
				}
				_currentZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("weaponZoomListener")] 
		public CHandle<HitIndicatorWeaponZoomListener> WeaponZoomListener
		{
			get
			{
				if (_weaponZoomListener == null)
				{
					_weaponZoomListener = (CHandle<HitIndicatorWeaponZoomListener>) CR2WTypeManager.Create("handle:HitIndicatorWeaponZoomListener", "weaponZoomListener", cr2w, this);
				}
				return _weaponZoomListener;
			}
			set
			{
				if (_weaponZoomListener == value)
				{
					return;
				}
				_weaponZoomListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("weaponID")] 
		public gameStatsObjectID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isAimingDownSights")] 
		public CBool IsAimingDownSights
		{
			get
			{
				if (_isAimingDownSights == null)
				{
					_isAimingDownSights = (CBool) CR2WTypeManager.Create("Bool", "isAimingDownSights", cr2w, this);
				}
				return _isAimingDownSights;
			}
			set
			{
				if (_isAimingDownSights == value)
				{
					return;
				}
				_isAimingDownSights = value;
				PropertySet(this);
			}
		}

		public TargetHitIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
