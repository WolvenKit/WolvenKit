using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseGameController : gameuiWidgetGameController
	{
		private wCHandle<inkWidget> _rootWidget;
		private CEnum<gamePSMCrosshairStates> _crosshairState;
		private CEnum<gamePSMVision> _visionState;
		private CUInt32 _crosshairStateBlackboardId;
		private CUInt32 _bulletSpreedBlackboardId;
		private CUInt32 _bbNPCStatsId;
		private CBool _isTargetDead;
		private CUInt64 _lastGUIStateUpdateFrame;
		private wCHandle<gameIBlackboard> _targetBB;
		private wCHandle<gameIBlackboard> _weaponBB;
		private CUInt32 _currentAimTargetBBID;
		private CUInt32 _targetDistanceBBID;
		private CUInt32 _targetAttitudeBBID;
		private wCHandle<entEntity> _targetEntity;
		private CHandle<CrosshairHealthChangeListener> _healthListener;
		private CBool _isActive;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get
			{
				if (_crosshairState == null)
				{
					_crosshairState = (CEnum<gamePSMCrosshairStates>) CR2WTypeManager.Create("gamePSMCrosshairStates", "crosshairState", cr2w, this);
				}
				return _crosshairState;
			}
			set
			{
				if (_crosshairState == value)
				{
					return;
				}
				_crosshairState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("visionState")] 
		public CEnum<gamePSMVision> VisionState
		{
			get
			{
				if (_visionState == null)
				{
					_visionState = (CEnum<gamePSMVision>) CR2WTypeManager.Create("gamePSMVision", "visionState", cr2w, this);
				}
				return _visionState;
			}
			set
			{
				if (_visionState == value)
				{
					return;
				}
				_visionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("crosshairStateBlackboardId")] 
		public CUInt32 CrosshairStateBlackboardId
		{
			get
			{
				if (_crosshairStateBlackboardId == null)
				{
					_crosshairStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "crosshairStateBlackboardId", cr2w, this);
				}
				return _crosshairStateBlackboardId;
			}
			set
			{
				if (_crosshairStateBlackboardId == value)
				{
					return;
				}
				_crosshairStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bulletSpreedBlackboardId")] 
		public CUInt32 BulletSpreedBlackboardId
		{
			get
			{
				if (_bulletSpreedBlackboardId == null)
				{
					_bulletSpreedBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "bulletSpreedBlackboardId", cr2w, this);
				}
				return _bulletSpreedBlackboardId;
			}
			set
			{
				if (_bulletSpreedBlackboardId == value)
				{
					return;
				}
				_bulletSpreedBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bbNPCStatsId")] 
		public CUInt32 BbNPCStatsId
		{
			get
			{
				if (_bbNPCStatsId == null)
				{
					_bbNPCStatsId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbNPCStatsId", cr2w, this);
				}
				return _bbNPCStatsId;
			}
			set
			{
				if (_bbNPCStatsId == value)
				{
					return;
				}
				_bbNPCStatsId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get
			{
				if (_isTargetDead == null)
				{
					_isTargetDead = (CBool) CR2WTypeManager.Create("Bool", "isTargetDead", cr2w, this);
				}
				return _isTargetDead;
			}
			set
			{
				if (_isTargetDead == value)
				{
					return;
				}
				_isTargetDead = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastGUIStateUpdateFrame")] 
		public CUInt64 LastGUIStateUpdateFrame
		{
			get
			{
				if (_lastGUIStateUpdateFrame == null)
				{
					_lastGUIStateUpdateFrame = (CUInt64) CR2WTypeManager.Create("Uint64", "lastGUIStateUpdateFrame", cr2w, this);
				}
				return _lastGUIStateUpdateFrame;
			}
			set
			{
				if (_lastGUIStateUpdateFrame == value)
				{
					return;
				}
				_lastGUIStateUpdateFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("targetBB")] 
		public wCHandle<gameIBlackboard> TargetBB
		{
			get
			{
				if (_targetBB == null)
				{
					_targetBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "targetBB", cr2w, this);
				}
				return _targetBB;
			}
			set
			{
				if (_targetBB == value)
				{
					return;
				}
				_targetBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("weaponBB")] 
		public wCHandle<gameIBlackboard> WeaponBB
		{
			get
			{
				if (_weaponBB == null)
				{
					_weaponBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "weaponBB", cr2w, this);
				}
				return _weaponBB;
			}
			set
			{
				if (_weaponBB == value)
				{
					return;
				}
				_weaponBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("currentAimTargetBBID")] 
		public CUInt32 CurrentAimTargetBBID
		{
			get
			{
				if (_currentAimTargetBBID == null)
				{
					_currentAimTargetBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentAimTargetBBID", cr2w, this);
				}
				return _currentAimTargetBBID;
			}
			set
			{
				if (_currentAimTargetBBID == value)
				{
					return;
				}
				_currentAimTargetBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetDistanceBBID")] 
		public CUInt32 TargetDistanceBBID
		{
			get
			{
				if (_targetDistanceBBID == null)
				{
					_targetDistanceBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetDistanceBBID", cr2w, this);
				}
				return _targetDistanceBBID;
			}
			set
			{
				if (_targetDistanceBBID == value)
				{
					return;
				}
				_targetDistanceBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("targetAttitudeBBID")] 
		public CUInt32 TargetAttitudeBBID
		{
			get
			{
				if (_targetAttitudeBBID == null)
				{
					_targetAttitudeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "targetAttitudeBBID", cr2w, this);
				}
				return _targetAttitudeBBID;
			}
			set
			{
				if (_targetAttitudeBBID == value)
				{
					return;
				}
				_targetAttitudeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("targetEntity")] 
		public wCHandle<entEntity> TargetEntity
		{
			get
			{
				if (_targetEntity == null)
				{
					_targetEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "targetEntity", cr2w, this);
				}
				return _targetEntity;
			}
			set
			{
				if (_targetEntity == value)
				{
					return;
				}
				_targetEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("healthListener")] 
		public CHandle<CrosshairHealthChangeListener> HealthListener
		{
			get
			{
				if (_healthListener == null)
				{
					_healthListener = (CHandle<CrosshairHealthChangeListener>) CR2WTypeManager.Create("handle:CrosshairHealthChangeListener", "healthListener", cr2w, this);
				}
				return _healthListener;
			}
			set
			{
				if (_healthListener == value)
				{
					return;
				}
				_healthListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameuiCrosshairBaseGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
