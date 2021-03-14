using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensorDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		private CBool _isRecognizableBySenses;
		private TargetingBehaviour _targetingBehaviour;
		private DetectionParameters _detectionParameters;
		private TweakDBID _lookAtPresetVert;
		private TweakDBID _lookAtPresetHor;
		private gameEffectRef _scanGameEffectRef;
		private gameEffectRef _visionConeEffectRef;
		private gameEffectRef _visionConeFriendlyEffectRef;
		private gameEffectRef _idleActiveRef;
		private gameEffectRef _idleFriendlyRef;
		private CBool _canTagEnemies;
		private CBool _tagLockFromSystem;
		private entEntityID _netrunnerID;
		private entEntityID _netrunnerProxyID;
		private entEntityID _netrunnerTargetID;
		private LinkedStatusEffect _linkedStatusEffect;
		private entEntityID _questForcedTargetID;
		private CBool _isInFollowMode;
		private CBool _isAttitudeChanged;
		private CBool _isInTagKillMode;
		private CBool _isIdleForced;
		private entEntityID _questTargetToSpot;
		private CBool _questTargetSpotted;
		private CBool _isAnyTargetIsLocked;
		private CBool _isPartOfPrevention;

		[Ordinal(119)] 
		[RED("isRecognizableBySenses")] 
		public CBool IsRecognizableBySenses
		{
			get
			{
				if (_isRecognizableBySenses == null)
				{
					_isRecognizableBySenses = (CBool) CR2WTypeManager.Create("Bool", "isRecognizableBySenses", cr2w, this);
				}
				return _isRecognizableBySenses;
			}
			set
			{
				if (_isRecognizableBySenses == value)
				{
					return;
				}
				_isRecognizableBySenses = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("targetingBehaviour")] 
		public TargetingBehaviour TargetingBehaviour
		{
			get
			{
				if (_targetingBehaviour == null)
				{
					_targetingBehaviour = (TargetingBehaviour) CR2WTypeManager.Create("TargetingBehaviour", "targetingBehaviour", cr2w, this);
				}
				return _targetingBehaviour;
			}
			set
			{
				if (_targetingBehaviour == value)
				{
					return;
				}
				_targetingBehaviour = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("detectionParameters")] 
		public DetectionParameters DetectionParameters
		{
			get
			{
				if (_detectionParameters == null)
				{
					_detectionParameters = (DetectionParameters) CR2WTypeManager.Create("DetectionParameters", "detectionParameters", cr2w, this);
				}
				return _detectionParameters;
			}
			set
			{
				if (_detectionParameters == value)
				{
					return;
				}
				_detectionParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("lookAtPresetVert")] 
		public TweakDBID LookAtPresetVert
		{
			get
			{
				if (_lookAtPresetVert == null)
				{
					_lookAtPresetVert = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lookAtPresetVert", cr2w, this);
				}
				return _lookAtPresetVert;
			}
			set
			{
				if (_lookAtPresetVert == value)
				{
					return;
				}
				_lookAtPresetVert = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("lookAtPresetHor")] 
		public TweakDBID LookAtPresetHor
		{
			get
			{
				if (_lookAtPresetHor == null)
				{
					_lookAtPresetHor = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lookAtPresetHor", cr2w, this);
				}
				return _lookAtPresetHor;
			}
			set
			{
				if (_lookAtPresetHor == value)
				{
					return;
				}
				_lookAtPresetHor = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("scanGameEffectRef")] 
		public gameEffectRef ScanGameEffectRef
		{
			get
			{
				if (_scanGameEffectRef == null)
				{
					_scanGameEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "scanGameEffectRef", cr2w, this);
				}
				return _scanGameEffectRef;
			}
			set
			{
				if (_scanGameEffectRef == value)
				{
					return;
				}
				_scanGameEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("visionConeEffectRef")] 
		public gameEffectRef VisionConeEffectRef
		{
			get
			{
				if (_visionConeEffectRef == null)
				{
					_visionConeEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "visionConeEffectRef", cr2w, this);
				}
				return _visionConeEffectRef;
			}
			set
			{
				if (_visionConeEffectRef == value)
				{
					return;
				}
				_visionConeEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("visionConeFriendlyEffectRef")] 
		public gameEffectRef VisionConeFriendlyEffectRef
		{
			get
			{
				if (_visionConeFriendlyEffectRef == null)
				{
					_visionConeFriendlyEffectRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "visionConeFriendlyEffectRef", cr2w, this);
				}
				return _visionConeFriendlyEffectRef;
			}
			set
			{
				if (_visionConeFriendlyEffectRef == value)
				{
					return;
				}
				_visionConeFriendlyEffectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("idleActiveRef")] 
		public gameEffectRef IdleActiveRef
		{
			get
			{
				if (_idleActiveRef == null)
				{
					_idleActiveRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "idleActiveRef", cr2w, this);
				}
				return _idleActiveRef;
			}
			set
			{
				if (_idleActiveRef == value)
				{
					return;
				}
				_idleActiveRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("idleFriendlyRef")] 
		public gameEffectRef IdleFriendlyRef
		{
			get
			{
				if (_idleFriendlyRef == null)
				{
					_idleFriendlyRef = (gameEffectRef) CR2WTypeManager.Create("gameEffectRef", "idleFriendlyRef", cr2w, this);
				}
				return _idleFriendlyRef;
			}
			set
			{
				if (_idleFriendlyRef == value)
				{
					return;
				}
				_idleFriendlyRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("canTagEnemies")] 
		public CBool CanTagEnemies
		{
			get
			{
				if (_canTagEnemies == null)
				{
					_canTagEnemies = (CBool) CR2WTypeManager.Create("Bool", "canTagEnemies", cr2w, this);
				}
				return _canTagEnemies;
			}
			set
			{
				if (_canTagEnemies == value)
				{
					return;
				}
				_canTagEnemies = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("tagLockFromSystem")] 
		public CBool TagLockFromSystem
		{
			get
			{
				if (_tagLockFromSystem == null)
				{
					_tagLockFromSystem = (CBool) CR2WTypeManager.Create("Bool", "tagLockFromSystem", cr2w, this);
				}
				return _tagLockFromSystem;
			}
			set
			{
				if (_tagLockFromSystem == value)
				{
					return;
				}
				_tagLockFromSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get
			{
				if (_netrunnerID == null)
				{
					_netrunnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "netrunnerID", cr2w, this);
				}
				return _netrunnerID;
			}
			set
			{
				if (_netrunnerID == value)
				{
					return;
				}
				_netrunnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("netrunnerProxyID")] 
		public entEntityID NetrunnerProxyID
		{
			get
			{
				if (_netrunnerProxyID == null)
				{
					_netrunnerProxyID = (entEntityID) CR2WTypeManager.Create("entEntityID", "netrunnerProxyID", cr2w, this);
				}
				return _netrunnerProxyID;
			}
			set
			{
				if (_netrunnerProxyID == value)
				{
					return;
				}
				_netrunnerProxyID = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("netrunnerTargetID")] 
		public entEntityID NetrunnerTargetID
		{
			get
			{
				if (_netrunnerTargetID == null)
				{
					_netrunnerTargetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "netrunnerTargetID", cr2w, this);
				}
				return _netrunnerTargetID;
			}
			set
			{
				if (_netrunnerTargetID == value)
				{
					return;
				}
				_netrunnerTargetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get
			{
				if (_linkedStatusEffect == null)
				{
					_linkedStatusEffect = (LinkedStatusEffect) CR2WTypeManager.Create("LinkedStatusEffect", "linkedStatusEffect", cr2w, this);
				}
				return _linkedStatusEffect;
			}
			set
			{
				if (_linkedStatusEffect == value)
				{
					return;
				}
				_linkedStatusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(135)] 
		[RED("questForcedTargetID")] 
		public entEntityID QuestForcedTargetID
		{
			get
			{
				if (_questForcedTargetID == null)
				{
					_questForcedTargetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "questForcedTargetID", cr2w, this);
				}
				return _questForcedTargetID;
			}
			set
			{
				if (_questForcedTargetID == value)
				{
					return;
				}
				_questForcedTargetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(136)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get
			{
				if (_isInFollowMode == null)
				{
					_isInFollowMode = (CBool) CR2WTypeManager.Create("Bool", "isInFollowMode", cr2w, this);
				}
				return _isInFollowMode;
			}
			set
			{
				if (_isInFollowMode == value)
				{
					return;
				}
				_isInFollowMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(137)] 
		[RED("isAttitudeChanged")] 
		public CBool IsAttitudeChanged
		{
			get
			{
				if (_isAttitudeChanged == null)
				{
					_isAttitudeChanged = (CBool) CR2WTypeManager.Create("Bool", "isAttitudeChanged", cr2w, this);
				}
				return _isAttitudeChanged;
			}
			set
			{
				if (_isAttitudeChanged == value)
				{
					return;
				}
				_isAttitudeChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(138)] 
		[RED("isInTagKillMode")] 
		public CBool IsInTagKillMode
		{
			get
			{
				if (_isInTagKillMode == null)
				{
					_isInTagKillMode = (CBool) CR2WTypeManager.Create("Bool", "isInTagKillMode", cr2w, this);
				}
				return _isInTagKillMode;
			}
			set
			{
				if (_isInTagKillMode == value)
				{
					return;
				}
				_isInTagKillMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(139)] 
		[RED("isIdleForced")] 
		public CBool IsIdleForced
		{
			get
			{
				if (_isIdleForced == null)
				{
					_isIdleForced = (CBool) CR2WTypeManager.Create("Bool", "isIdleForced", cr2w, this);
				}
				return _isIdleForced;
			}
			set
			{
				if (_isIdleForced == value)
				{
					return;
				}
				_isIdleForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(140)] 
		[RED("questTargetToSpot")] 
		public entEntityID QuestTargetToSpot
		{
			get
			{
				if (_questTargetToSpot == null)
				{
					_questTargetToSpot = (entEntityID) CR2WTypeManager.Create("entEntityID", "questTargetToSpot", cr2w, this);
				}
				return _questTargetToSpot;
			}
			set
			{
				if (_questTargetToSpot == value)
				{
					return;
				}
				_questTargetToSpot = value;
				PropertySet(this);
			}
		}

		[Ordinal(141)] 
		[RED("questTargetSpotted")] 
		public CBool QuestTargetSpotted
		{
			get
			{
				if (_questTargetSpotted == null)
				{
					_questTargetSpotted = (CBool) CR2WTypeManager.Create("Bool", "questTargetSpotted", cr2w, this);
				}
				return _questTargetSpotted;
			}
			set
			{
				if (_questTargetSpotted == value)
				{
					return;
				}
				_questTargetSpotted = value;
				PropertySet(this);
			}
		}

		[Ordinal(142)] 
		[RED("isAnyTargetIsLocked")] 
		public CBool IsAnyTargetIsLocked
		{
			get
			{
				if (_isAnyTargetIsLocked == null)
				{
					_isAnyTargetIsLocked = (CBool) CR2WTypeManager.Create("Bool", "isAnyTargetIsLocked", cr2w, this);
				}
				return _isAnyTargetIsLocked;
			}
			set
			{
				if (_isAnyTargetIsLocked == value)
				{
					return;
				}
				_isAnyTargetIsLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(143)] 
		[RED("isPartOfPrevention")] 
		public CBool IsPartOfPrevention
		{
			get
			{
				if (_isPartOfPrevention == null)
				{
					_isPartOfPrevention = (CBool) CR2WTypeManager.Create("Bool", "isPartOfPrevention", cr2w, this);
				}
				return _isPartOfPrevention;
			}
			set
			{
				if (_isPartOfPrevention == value)
				{
					return;
				}
				_isPartOfPrevention = value;
				PropertySet(this);
			}
		}

		public SensorDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
