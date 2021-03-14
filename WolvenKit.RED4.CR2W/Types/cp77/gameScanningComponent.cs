using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponent : gameComponent
	{
		private CArray<gameScanningTooltipElementDef> _scannableData;
		private CFloat _timeNeeded;
		private CBool _autoGenerateBoundingSphere;
		private Sphere _boundingSphere;
		private CBool _ignoresScanningDistanceLimit;
		private CBool _cpoEnableMultiplePlayersScanningModifier;
		private CBool _isBraindanceClue;
		private CEnum<braindanceVisionMode> _braindanceLayer;
		private CBool _isBraindanceBlocked;
		private CBool _isBraindanceLayerUnlocked;
		private CBool _isBraindanceTimelineUnlocked;
		private CBool _isBraindanceActive;
		private CInt32 _currentBraindanceLayer;
		private CArray<FocusClueDefinition> _clues;
		private CHandle<ObjectScanningDescription> _objectDescription;
		private TweakDBID _scanningBarText;
		private CBool _isFocusModeActive;
		private CHandle<FocusForcedHighlightData> _currentHighlight;
		private CBool _isHudManagerInitialized;
		private CBool _isBeingScanned;
		private CBool _isScanningCluesBlocked;
		private CBool _isEntityVisible;

		[Ordinal(4)] 
		[RED("scannableData")] 
		public CArray<gameScanningTooltipElementDef> ScannableData
		{
			get
			{
				if (_scannableData == null)
				{
					_scannableData = (CArray<gameScanningTooltipElementDef>) CR2WTypeManager.Create("array:gameScanningTooltipElementDef", "scannableData", cr2w, this);
				}
				return _scannableData;
			}
			set
			{
				if (_scannableData == value)
				{
					return;
				}
				_scannableData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeNeeded")] 
		public CFloat TimeNeeded
		{
			get
			{
				if (_timeNeeded == null)
				{
					_timeNeeded = (CFloat) CR2WTypeManager.Create("Float", "timeNeeded", cr2w, this);
				}
				return _timeNeeded;
			}
			set
			{
				if (_timeNeeded == value)
				{
					return;
				}
				_timeNeeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autoGenerateBoundingSphere")] 
		public CBool AutoGenerateBoundingSphere
		{
			get
			{
				if (_autoGenerateBoundingSphere == null)
				{
					_autoGenerateBoundingSphere = (CBool) CR2WTypeManager.Create("Bool", "autoGenerateBoundingSphere", cr2w, this);
				}
				return _autoGenerateBoundingSphere;
			}
			set
			{
				if (_autoGenerateBoundingSphere == value)
				{
					return;
				}
				_autoGenerateBoundingSphere = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("boundingSphere")] 
		public Sphere BoundingSphere
		{
			get
			{
				if (_boundingSphere == null)
				{
					_boundingSphere = (Sphere) CR2WTypeManager.Create("Sphere", "boundingSphere", cr2w, this);
				}
				return _boundingSphere;
			}
			set
			{
				if (_boundingSphere == value)
				{
					return;
				}
				_boundingSphere = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ignoresScanningDistanceLimit")] 
		public CBool IgnoresScanningDistanceLimit
		{
			get
			{
				if (_ignoresScanningDistanceLimit == null)
				{
					_ignoresScanningDistanceLimit = (CBool) CR2WTypeManager.Create("Bool", "ignoresScanningDistanceLimit", cr2w, this);
				}
				return _ignoresScanningDistanceLimit;
			}
			set
			{
				if (_ignoresScanningDistanceLimit == value)
				{
					return;
				}
				_ignoresScanningDistanceLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("cpoEnableMultiplePlayersScanningModifier")] 
		public CBool CpoEnableMultiplePlayersScanningModifier
		{
			get
			{
				if (_cpoEnableMultiplePlayersScanningModifier == null)
				{
					_cpoEnableMultiplePlayersScanningModifier = (CBool) CR2WTypeManager.Create("Bool", "cpoEnableMultiplePlayersScanningModifier", cr2w, this);
				}
				return _cpoEnableMultiplePlayersScanningModifier;
			}
			set
			{
				if (_cpoEnableMultiplePlayersScanningModifier == value)
				{
					return;
				}
				_cpoEnableMultiplePlayersScanningModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isBraindanceClue")] 
		public CBool IsBraindanceClue
		{
			get
			{
				if (_isBraindanceClue == null)
				{
					_isBraindanceClue = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceClue", cr2w, this);
				}
				return _isBraindanceClue;
			}
			set
			{
				if (_isBraindanceClue == value)
				{
					return;
				}
				_isBraindanceClue = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("BraindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get
			{
				if (_braindanceLayer == null)
				{
					_braindanceLayer = (CEnum<braindanceVisionMode>) CR2WTypeManager.Create("braindanceVisionMode", "BraindanceLayer", cr2w, this);
				}
				return _braindanceLayer;
			}
			set
			{
				if (_braindanceLayer == value)
				{
					return;
				}
				_braindanceLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isBraindanceBlocked")] 
		public CBool IsBraindanceBlocked
		{
			get
			{
				if (_isBraindanceBlocked == null)
				{
					_isBraindanceBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceBlocked", cr2w, this);
				}
				return _isBraindanceBlocked;
			}
			set
			{
				if (_isBraindanceBlocked == value)
				{
					return;
				}
				_isBraindanceBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isBraindanceLayerUnlocked")] 
		public CBool IsBraindanceLayerUnlocked
		{
			get
			{
				if (_isBraindanceLayerUnlocked == null)
				{
					_isBraindanceLayerUnlocked = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceLayerUnlocked", cr2w, this);
				}
				return _isBraindanceLayerUnlocked;
			}
			set
			{
				if (_isBraindanceLayerUnlocked == value)
				{
					return;
				}
				_isBraindanceLayerUnlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isBraindanceTimelineUnlocked")] 
		public CBool IsBraindanceTimelineUnlocked
		{
			get
			{
				if (_isBraindanceTimelineUnlocked == null)
				{
					_isBraindanceTimelineUnlocked = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceTimelineUnlocked", cr2w, this);
				}
				return _isBraindanceTimelineUnlocked;
			}
			set
			{
				if (_isBraindanceTimelineUnlocked == value)
				{
					return;
				}
				_isBraindanceTimelineUnlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isBraindanceActive")] 
		public CBool IsBraindanceActive
		{
			get
			{
				if (_isBraindanceActive == null)
				{
					_isBraindanceActive = (CBool) CR2WTypeManager.Create("Bool", "isBraindanceActive", cr2w, this);
				}
				return _isBraindanceActive;
			}
			set
			{
				if (_isBraindanceActive == value)
				{
					return;
				}
				_isBraindanceActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentBraindanceLayer")] 
		public CInt32 CurrentBraindanceLayer
		{
			get
			{
				if (_currentBraindanceLayer == null)
				{
					_currentBraindanceLayer = (CInt32) CR2WTypeManager.Create("Int32", "currentBraindanceLayer", cr2w, this);
				}
				return _currentBraindanceLayer;
			}
			set
			{
				if (_currentBraindanceLayer == value)
				{
					return;
				}
				_currentBraindanceLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("clues")] 
		public CArray<FocusClueDefinition> Clues
		{
			get
			{
				if (_clues == null)
				{
					_clues = (CArray<FocusClueDefinition>) CR2WTypeManager.Create("array:FocusClueDefinition", "clues", cr2w, this);
				}
				return _clues;
			}
			set
			{
				if (_clues == value)
				{
					return;
				}
				_clues = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get
			{
				if (_objectDescription == null)
				{
					_objectDescription = (CHandle<ObjectScanningDescription>) CR2WTypeManager.Create("handle:ObjectScanningDescription", "objectDescription", cr2w, this);
				}
				return _objectDescription;
			}
			set
			{
				if (_objectDescription == value)
				{
					return;
				}
				_objectDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("scanningBarText")] 
		public TweakDBID ScanningBarText
		{
			get
			{
				if (_scanningBarText == null)
				{
					_scanningBarText = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "scanningBarText", cr2w, this);
				}
				return _scanningBarText;
			}
			set
			{
				if (_scanningBarText == value)
				{
					return;
				}
				_scanningBarText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get
			{
				if (_isFocusModeActive == null)
				{
					_isFocusModeActive = (CBool) CR2WTypeManager.Create("Bool", "isFocusModeActive", cr2w, this);
				}
				return _isFocusModeActive;
			}
			set
			{
				if (_isFocusModeActive == value)
				{
					return;
				}
				_isFocusModeActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentHighlight
		{
			get
			{
				if (_currentHighlight == null)
				{
					_currentHighlight = (CHandle<FocusForcedHighlightData>) CR2WTypeManager.Create("handle:FocusForcedHighlightData", "currentHighlight", cr2w, this);
				}
				return _currentHighlight;
			}
			set
			{
				if (_currentHighlight == value)
				{
					return;
				}
				_currentHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isHudManagerInitialized")] 
		public CBool IsHudManagerInitialized
		{
			get
			{
				if (_isHudManagerInitialized == null)
				{
					_isHudManagerInitialized = (CBool) CR2WTypeManager.Create("Bool", "isHudManagerInitialized", cr2w, this);
				}
				return _isHudManagerInitialized;
			}
			set
			{
				if (_isHudManagerInitialized == value)
				{
					return;
				}
				_isHudManagerInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get
			{
				if (_isBeingScanned == null)
				{
					_isBeingScanned = (CBool) CR2WTypeManager.Create("Bool", "isBeingScanned", cr2w, this);
				}
				return _isBeingScanned;
			}
			set
			{
				if (_isBeingScanned == value)
				{
					return;
				}
				_isBeingScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get
			{
				if (_isScanningCluesBlocked == null)
				{
					_isScanningCluesBlocked = (CBool) CR2WTypeManager.Create("Bool", "isScanningCluesBlocked", cr2w, this);
				}
				return _isScanningCluesBlocked;
			}
			set
			{
				if (_isScanningCluesBlocked == value)
				{
					return;
				}
				_isScanningCluesBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isEntityVisible")] 
		public CBool IsEntityVisible
		{
			get
			{
				if (_isEntityVisible == null)
				{
					_isEntityVisible = (CBool) CR2WTypeManager.Create("Bool", "isEntityVisible", cr2w, this);
				}
				return _isEntityVisible;
			}
			set
			{
				if (_isEntityVisible == value)
				{
					return;
				}
				_isEntityVisible = value;
				PropertySet(this);
			}
		}

		public gameScanningComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
