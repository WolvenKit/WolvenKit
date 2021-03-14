using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DroneComponent : gameScriptableComponent
	{
		private CHandle<senseComponent> _senseComponent;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entSimpleColliderComponent> _playerOnlyCollisionComponent;
		private CUInt32 _highLevelCb;
		private CEnum<MechanicalScanType> _currentScanType;
		private CHandle<gameEffectInstance> _currentScanEffect;
		private CName _currentScanAnimation;
		private CBool _isDetectionScanning;
		private wCHandle<gameObject> _trackedTarget;
		private CName _currentLocomotionWrapper;

		[Ordinal(5)] 
		[RED("senseComponent")] 
		public CHandle<senseComponent> SenseComponent
		{
			get
			{
				if (_senseComponent == null)
				{
					_senseComponent = (CHandle<senseComponent>) CR2WTypeManager.Create("handle:senseComponent", "senseComponent", cr2w, this);
				}
				return _senseComponent;
			}
			set
			{
				if (_senseComponent == value)
				{
					return;
				}
				_senseComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get
			{
				if (_npcCollisionComponent == null)
				{
					_npcCollisionComponent = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "npcCollisionComponent", cr2w, this);
				}
				return _npcCollisionComponent;
			}
			set
			{
				if (_npcCollisionComponent == value)
				{
					return;
				}
				_npcCollisionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerOnlyCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> PlayerOnlyCollisionComponent
		{
			get
			{
				if (_playerOnlyCollisionComponent == null)
				{
					_playerOnlyCollisionComponent = (CHandle<entSimpleColliderComponent>) CR2WTypeManager.Create("handle:entSimpleColliderComponent", "playerOnlyCollisionComponent", cr2w, this);
				}
				return _playerOnlyCollisionComponent;
			}
			set
			{
				if (_playerOnlyCollisionComponent == value)
				{
					return;
				}
				_playerOnlyCollisionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get
			{
				if (_highLevelCb == null)
				{
					_highLevelCb = (CUInt32) CR2WTypeManager.Create("Uint32", "highLevelCb", cr2w, this);
				}
				return _highLevelCb;
			}
			set
			{
				if (_highLevelCb == value)
				{
					return;
				}
				_highLevelCb = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get
			{
				if (_currentScanType == null)
				{
					_currentScanType = (CEnum<MechanicalScanType>) CR2WTypeManager.Create("MechanicalScanType", "currentScanType", cr2w, this);
				}
				return _currentScanType;
			}
			set
			{
				if (_currentScanType == value)
				{
					return;
				}
				_currentScanType = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get
			{
				if (_currentScanEffect == null)
				{
					_currentScanEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "currentScanEffect", cr2w, this);
				}
				return _currentScanEffect;
			}
			set
			{
				if (_currentScanEffect == value)
				{
					return;
				}
				_currentScanEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get
			{
				if (_currentScanAnimation == null)
				{
					_currentScanAnimation = (CName) CR2WTypeManager.Create("CName", "currentScanAnimation", cr2w, this);
				}
				return _currentScanAnimation;
			}
			set
			{
				if (_currentScanAnimation == value)
				{
					return;
				}
				_currentScanAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isDetectionScanning")] 
		public CBool IsDetectionScanning
		{
			get
			{
				if (_isDetectionScanning == null)
				{
					_isDetectionScanning = (CBool) CR2WTypeManager.Create("Bool", "isDetectionScanning", cr2w, this);
				}
				return _isDetectionScanning;
			}
			set
			{
				if (_isDetectionScanning == value)
				{
					return;
				}
				_isDetectionScanning = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("trackedTarget")] 
		public wCHandle<gameObject> TrackedTarget
		{
			get
			{
				if (_trackedTarget == null)
				{
					_trackedTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "trackedTarget", cr2w, this);
				}
				return _trackedTarget;
			}
			set
			{
				if (_trackedTarget == value)
				{
					return;
				}
				_trackedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("currentLocomotionWrapper")] 
		public CName CurrentLocomotionWrapper
		{
			get
			{
				if (_currentLocomotionWrapper == null)
				{
					_currentLocomotionWrapper = (CName) CR2WTypeManager.Create("CName", "currentLocomotionWrapper", cr2w, this);
				}
				return _currentLocomotionWrapper;
			}
			set
			{
				if (_currentLocomotionWrapper == value)
				{
					return;
				}
				_currentLocomotionWrapper = value;
				PropertySet(this);
			}
		}

		public DroneComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
