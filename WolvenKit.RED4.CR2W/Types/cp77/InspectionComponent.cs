using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionComponent : gameScriptableComponent
	{
		private CString _slot;
		private CFloat _cumulatedObjRotationX;
		private CFloat _cumulatedObjRotationY;
		private CFloat _maxObjOffset;
		private CFloat _minObjOffset;
		private CFloat _zoomSpeed;
		private CFloat _timeToScan;
		private CBool _isPlayerInspecting;
		private CString _activeClue;
		private CBool _isScanAvailable;
		private CBool _scanningInProgress;
		private CBool _objectScanned;
		private CHandle<AnimFeature_Inspection> _animFeature;
		private CHandle<IScriptable> _listener;
		private entEntityID _lastInspectedObjID;

		[Ordinal(5)] 
		[RED("slot")] 
		public CString Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (CString) CR2WTypeManager.Create("String", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("cumulatedObjRotationX")] 
		public CFloat CumulatedObjRotationX
		{
			get
			{
				if (_cumulatedObjRotationX == null)
				{
					_cumulatedObjRotationX = (CFloat) CR2WTypeManager.Create("Float", "cumulatedObjRotationX", cr2w, this);
				}
				return _cumulatedObjRotationX;
			}
			set
			{
				if (_cumulatedObjRotationX == value)
				{
					return;
				}
				_cumulatedObjRotationX = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cumulatedObjRotationY")] 
		public CFloat CumulatedObjRotationY
		{
			get
			{
				if (_cumulatedObjRotationY == null)
				{
					_cumulatedObjRotationY = (CFloat) CR2WTypeManager.Create("Float", "cumulatedObjRotationY", cr2w, this);
				}
				return _cumulatedObjRotationY;
			}
			set
			{
				if (_cumulatedObjRotationY == value)
				{
					return;
				}
				_cumulatedObjRotationY = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maxObjOffset")] 
		public CFloat MaxObjOffset
		{
			get
			{
				if (_maxObjOffset == null)
				{
					_maxObjOffset = (CFloat) CR2WTypeManager.Create("Float", "maxObjOffset", cr2w, this);
				}
				return _maxObjOffset;
			}
			set
			{
				if (_maxObjOffset == value)
				{
					return;
				}
				_maxObjOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("minObjOffset")] 
		public CFloat MinObjOffset
		{
			get
			{
				if (_minObjOffset == null)
				{
					_minObjOffset = (CFloat) CR2WTypeManager.Create("Float", "minObjOffset", cr2w, this);
				}
				return _minObjOffset;
			}
			set
			{
				if (_minObjOffset == value)
				{
					return;
				}
				_minObjOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get
			{
				if (_zoomSpeed == null)
				{
					_zoomSpeed = (CFloat) CR2WTypeManager.Create("Float", "zoomSpeed", cr2w, this);
				}
				return _zoomSpeed;
			}
			set
			{
				if (_zoomSpeed == value)
				{
					return;
				}
				_zoomSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get
			{
				if (_timeToScan == null)
				{
					_timeToScan = (CFloat) CR2WTypeManager.Create("Float", "timeToScan", cr2w, this);
				}
				return _timeToScan;
			}
			set
			{
				if (_timeToScan == value)
				{
					return;
				}
				_timeToScan = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isPlayerInspecting")] 
		public CBool IsPlayerInspecting
		{
			get
			{
				if (_isPlayerInspecting == null)
				{
					_isPlayerInspecting = (CBool) CR2WTypeManager.Create("Bool", "isPlayerInspecting", cr2w, this);
				}
				return _isPlayerInspecting;
			}
			set
			{
				if (_isPlayerInspecting == value)
				{
					return;
				}
				_isPlayerInspecting = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("activeClue")] 
		public CString ActiveClue
		{
			get
			{
				if (_activeClue == null)
				{
					_activeClue = (CString) CR2WTypeManager.Create("String", "activeClue", cr2w, this);
				}
				return _activeClue;
			}
			set
			{
				if (_activeClue == value)
				{
					return;
				}
				_activeClue = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isScanAvailable")] 
		public CBool IsScanAvailable
		{
			get
			{
				if (_isScanAvailable == null)
				{
					_isScanAvailable = (CBool) CR2WTypeManager.Create("Bool", "isScanAvailable", cr2w, this);
				}
				return _isScanAvailable;
			}
			set
			{
				if (_isScanAvailable == value)
				{
					return;
				}
				_isScanAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("scanningInProgress")] 
		public CBool ScanningInProgress
		{
			get
			{
				if (_scanningInProgress == null)
				{
					_scanningInProgress = (CBool) CR2WTypeManager.Create("Bool", "scanningInProgress", cr2w, this);
				}
				return _scanningInProgress;
			}
			set
			{
				if (_scanningInProgress == value)
				{
					return;
				}
				_scanningInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("objectScanned")] 
		public CBool ObjectScanned
		{
			get
			{
				if (_objectScanned == null)
				{
					_objectScanned = (CBool) CR2WTypeManager.Create("Bool", "objectScanned", cr2w, this);
				}
				return _objectScanned;
			}
			set
			{
				if (_objectScanned == value)
				{
					return;
				}
				_objectScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Inspection> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_Inspection>) CR2WTypeManager.Create("handle:AnimFeature_Inspection", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("listener")] 
		public CHandle<IScriptable> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("lastInspectedObjID")] 
		public entEntityID LastInspectedObjID
		{
			get
			{
				if (_lastInspectedObjID == null)
				{
					_lastInspectedObjID = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastInspectedObjID", cr2w, this);
				}
				return _lastInspectedObjID;
			}
			set
			{
				if (_lastInspectedObjID == value)
				{
					return;
				}
				_lastInspectedObjID = value;
				PropertySet(this);
			}
		}

		public InspectionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
