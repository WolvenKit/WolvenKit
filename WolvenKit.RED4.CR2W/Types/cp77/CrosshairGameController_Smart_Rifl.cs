using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Smart_Rifl : gameuiCrosshairBaseGameController
	{
		private inkTextWidgetReference _txtAccuracy;
		private inkTextWidgetReference _txtTargetsCount;
		private inkTextWidgetReference _txtFluffStatus;
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private inkImageWidgetReference _leftPartExtra;
		private inkImageWidgetReference _rightPartExtra;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private inkImageWidgetReference _topPart;
		private inkImageWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private CName _targetWidgetLibraryName;
		private CInt32 _targetsPullSize;
		private inkWidgetReference _targetColorChange;
		private inkWidgetReference _targetingFrame;
		private inkWidgetReference _reticleFrame;
		private inkWidgetReference _bufferFrame;
		private inkCompoundWidgetReference _targetHolder;
		private inkCompoundWidgetReference _lockHolder;
		private inkCompoundWidgetReference _reloadIndicator;
		private inkCompoundWidgetReference _reloadIndicatorInv;
		private inkCompoundWidgetReference _smartLinkDot;
		private inkCompoundWidgetReference _smartLinkFrame;
		private inkCompoundWidgetReference _smartLinkFluff;
		private inkCompoundWidgetReference _smartLinkFirmwareOnline;
		private inkCompoundWidgetReference _smartLinkFirmwareOffline;
		private wCHandle<gameIBlackboard> _weaponBlackboard;
		private CUInt32 _weaponParamsListenerId;
		private CArray<wCHandle<inkWidget>> _targets;
		private CArray<gamesmartGunUITargetParameters> _targetsData;
		private CBool _isBlocked;
		private CBool _isAimDownSights;
		private Vector2 _bufferedSpread;
		private CHandle<inkanimProxy> _reloadAnimationProxy;
		private CArray<entEntityID> _prevTargetedEntityIDs;

		[Ordinal(18)] 
		[RED("txtAccuracy")] 
		public inkTextWidgetReference TxtAccuracy
		{
			get
			{
				if (_txtAccuracy == null)
				{
					_txtAccuracy = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "txtAccuracy", cr2w, this);
				}
				return _txtAccuracy;
			}
			set
			{
				if (_txtAccuracy == value)
				{
					return;
				}
				_txtAccuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("txtTargetsCount")] 
		public inkTextWidgetReference TxtTargetsCount
		{
			get
			{
				if (_txtTargetsCount == null)
				{
					_txtTargetsCount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "txtTargetsCount", cr2w, this);
				}
				return _txtTargetsCount;
			}
			set
			{
				if (_txtTargetsCount == value)
				{
					return;
				}
				_txtTargetsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("txtFluffStatus")] 
		public inkTextWidgetReference TxtFluffStatus
		{
			get
			{
				if (_txtFluffStatus == null)
				{
					_txtFluffStatus = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "txtFluffStatus", cr2w, this);
				}
				return _txtFluffStatus;
			}
			set
			{
				if (_txtFluffStatus == value)
				{
					return;
				}
				_txtFluffStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "leftPart", cr2w, this);
				}
				return _leftPart;
			}
			set
			{
				if (_leftPart == value)
				{
					return;
				}
				_leftPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "rightPart", cr2w, this);
				}
				return _rightPart;
			}
			set
			{
				if (_rightPart == value)
				{
					return;
				}
				_rightPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get
			{
				if (_leftPartExtra == null)
				{
					_leftPartExtra = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "leftPartExtra", cr2w, this);
				}
				return _leftPartExtra;
			}
			set
			{
				if (_leftPartExtra == value)
				{
					return;
				}
				_leftPartExtra = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get
			{
				if (_rightPartExtra == null)
				{
					_rightPartExtra = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "rightPartExtra", cr2w, this);
				}
				return _rightPartExtra;
			}
			set
			{
				if (_rightPartExtra == value)
				{
					return;
				}
				_rightPartExtra = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get
			{
				if (_offsetLeftRight == null)
				{
					_offsetLeftRight = (CFloat) CR2WTypeManager.Create("Float", "offsetLeftRight", cr2w, this);
				}
				return _offsetLeftRight;
			}
			set
			{
				if (_offsetLeftRight == value)
				{
					return;
				}
				_offsetLeftRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get
			{
				if (_offsetLeftRightExtra == null)
				{
					_offsetLeftRightExtra = (CFloat) CR2WTypeManager.Create("Float", "offsetLeftRightExtra", cr2w, this);
				}
				return _offsetLeftRightExtra;
			}
			set
			{
				if (_offsetLeftRightExtra == value)
				{
					return;
				}
				_offsetLeftRightExtra = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get
			{
				if (_latchVertical == null)
				{
					_latchVertical = (CFloat) CR2WTypeManager.Create("Float", "latchVertical", cr2w, this);
				}
				return _latchVertical;
			}
			set
			{
				if (_latchVertical == value)
				{
					return;
				}
				_latchVertical = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get
			{
				if (_topPart == null)
				{
					_topPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "topPart", cr2w, this);
				}
				return _topPart;
			}
			set
			{
				if (_topPart == value)
				{
					return;
				}
				_topPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get
			{
				if (_bottomPart == null)
				{
					_bottomPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "bottomPart", cr2w, this);
				}
				return _bottomPart;
			}
			set
			{
				if (_bottomPart == value)
				{
					return;
				}
				_bottomPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get
			{
				if (_horiPart == null)
				{
					_horiPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "horiPart", cr2w, this);
				}
				return _horiPart;
			}
			set
			{
				if (_horiPart == value)
				{
					return;
				}
				_horiPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get
			{
				if (_vertPart == null)
				{
					_vertPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vertPart", cr2w, this);
				}
				return _vertPart;
			}
			set
			{
				if (_vertPart == value)
				{
					return;
				}
				_vertPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get
			{
				if (_targetWidgetLibraryName == null)
				{
					_targetWidgetLibraryName = (CName) CR2WTypeManager.Create("CName", "targetWidgetLibraryName", cr2w, this);
				}
				return _targetWidgetLibraryName;
			}
			set
			{
				if (_targetWidgetLibraryName == value)
				{
					return;
				}
				_targetWidgetLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("targetsPullSize")] 
		public CInt32 TargetsPullSize
		{
			get
			{
				if (_targetsPullSize == null)
				{
					_targetsPullSize = (CInt32) CR2WTypeManager.Create("Int32", "targetsPullSize", cr2w, this);
				}
				return _targetsPullSize;
			}
			set
			{
				if (_targetsPullSize == value)
				{
					return;
				}
				_targetsPullSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get
			{
				if (_targetColorChange == null)
				{
					_targetColorChange = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetColorChange", cr2w, this);
				}
				return _targetColorChange;
			}
			set
			{
				if (_targetColorChange == value)
				{
					return;
				}
				_targetColorChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("targetingFrame")] 
		public inkWidgetReference TargetingFrame
		{
			get
			{
				if (_targetingFrame == null)
				{
					_targetingFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetingFrame", cr2w, this);
				}
				return _targetingFrame;
			}
			set
			{
				if (_targetingFrame == value)
				{
					return;
				}
				_targetingFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("reticleFrame")] 
		public inkWidgetReference ReticleFrame
		{
			get
			{
				if (_reticleFrame == null)
				{
					_reticleFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "reticleFrame", cr2w, this);
				}
				return _reticleFrame;
			}
			set
			{
				if (_reticleFrame == value)
				{
					return;
				}
				_reticleFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("bufferFrame")] 
		public inkWidgetReference BufferFrame
		{
			get
			{
				if (_bufferFrame == null)
				{
					_bufferFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bufferFrame", cr2w, this);
				}
				return _bufferFrame;
			}
			set
			{
				if (_bufferFrame == value)
				{
					return;
				}
				_bufferFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get
			{
				if (_targetHolder == null)
				{
					_targetHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "targetHolder", cr2w, this);
				}
				return _targetHolder;
			}
			set
			{
				if (_targetHolder == value)
				{
					return;
				}
				_targetHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("lockHolder")] 
		public inkCompoundWidgetReference LockHolder
		{
			get
			{
				if (_lockHolder == null)
				{
					_lockHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "lockHolder", cr2w, this);
				}
				return _lockHolder;
			}
			set
			{
				if (_lockHolder == value)
				{
					return;
				}
				_lockHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("reloadIndicator")] 
		public inkCompoundWidgetReference ReloadIndicator
		{
			get
			{
				if (_reloadIndicator == null)
				{
					_reloadIndicator = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "reloadIndicator", cr2w, this);
				}
				return _reloadIndicator;
			}
			set
			{
				if (_reloadIndicator == value)
				{
					return;
				}
				_reloadIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("reloadIndicatorInv")] 
		public inkCompoundWidgetReference ReloadIndicatorInv
		{
			get
			{
				if (_reloadIndicatorInv == null)
				{
					_reloadIndicatorInv = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "reloadIndicatorInv", cr2w, this);
				}
				return _reloadIndicatorInv;
			}
			set
			{
				if (_reloadIndicatorInv == value)
				{
					return;
				}
				_reloadIndicatorInv = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("smartLinkDot")] 
		public inkCompoundWidgetReference SmartLinkDot
		{
			get
			{
				if (_smartLinkDot == null)
				{
					_smartLinkDot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkDot", cr2w, this);
				}
				return _smartLinkDot;
			}
			set
			{
				if (_smartLinkDot == value)
				{
					return;
				}
				_smartLinkDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("smartLinkFrame")] 
		public inkCompoundWidgetReference SmartLinkFrame
		{
			get
			{
				if (_smartLinkFrame == null)
				{
					_smartLinkFrame = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFrame", cr2w, this);
				}
				return _smartLinkFrame;
			}
			set
			{
				if (_smartLinkFrame == value)
				{
					return;
				}
				_smartLinkFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("smartLinkFluff")] 
		public inkCompoundWidgetReference SmartLinkFluff
		{
			get
			{
				if (_smartLinkFluff == null)
				{
					_smartLinkFluff = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFluff", cr2w, this);
				}
				return _smartLinkFluff;
			}
			set
			{
				if (_smartLinkFluff == value)
				{
					return;
				}
				_smartLinkFluff = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get
			{
				if (_smartLinkFirmwareOnline == null)
				{
					_smartLinkFirmwareOnline = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFirmwareOnline", cr2w, this);
				}
				return _smartLinkFirmwareOnline;
			}
			set
			{
				if (_smartLinkFirmwareOnline == value)
				{
					return;
				}
				_smartLinkFirmwareOnline = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get
			{
				if (_smartLinkFirmwareOffline == null)
				{
					_smartLinkFirmwareOffline = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "smartLinkFirmwareOffline", cr2w, this);
				}
				return _smartLinkFirmwareOffline;
			}
			set
			{
				if (_smartLinkFirmwareOffline == value)
				{
					return;
				}
				_smartLinkFirmwareOffline = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("weaponBlackboard")] 
		public wCHandle<gameIBlackboard> WeaponBlackboard
		{
			get
			{
				if (_weaponBlackboard == null)
				{
					_weaponBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "weaponBlackboard", cr2w, this);
				}
				return _weaponBlackboard;
			}
			set
			{
				if (_weaponBlackboard == value)
				{
					return;
				}
				_weaponBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("weaponParamsListenerId")] 
		public CUInt32 WeaponParamsListenerId
		{
			get
			{
				if (_weaponParamsListenerId == null)
				{
					_weaponParamsListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponParamsListenerId", cr2w, this);
				}
				return _weaponParamsListenerId;
			}
			set
			{
				if (_weaponParamsListenerId == value)
				{
					return;
				}
				_weaponParamsListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("targets")] 
		public CArray<wCHandle<inkWidget>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("targetsData")] 
		public CArray<gamesmartGunUITargetParameters> TargetsData
		{
			get
			{
				if (_targetsData == null)
				{
					_targetsData = (CArray<gamesmartGunUITargetParameters>) CR2WTypeManager.Create("array:gamesmartGunUITargetParameters", "targetsData", cr2w, this);
				}
				return _targetsData;
			}
			set
			{
				if (_targetsData == value)
				{
					return;
				}
				_targetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("isAimDownSights")] 
		public CBool IsAimDownSights
		{
			get
			{
				if (_isAimDownSights == null)
				{
					_isAimDownSights = (CBool) CR2WTypeManager.Create("Bool", "isAimDownSights", cr2w, this);
				}
				return _isAimDownSights;
			}
			set
			{
				if (_isAimDownSights == value)
				{
					return;
				}
				_isAimDownSights = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get
			{
				if (_bufferedSpread == null)
				{
					_bufferedSpread = (Vector2) CR2WTypeManager.Create("Vector2", "bufferedSpread", cr2w, this);
				}
				return _bufferedSpread;
			}
			set
			{
				if (_bufferedSpread == value)
				{
					return;
				}
				_bufferedSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("reloadAnimationProxy")] 
		public CHandle<inkanimProxy> ReloadAnimationProxy
		{
			get
			{
				if (_reloadAnimationProxy == null)
				{
					_reloadAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "reloadAnimationProxy", cr2w, this);
				}
				return _reloadAnimationProxy;
			}
			set
			{
				if (_reloadAnimationProxy == value)
				{
					return;
				}
				_reloadAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("prevTargetedEntityIDs")] 
		public CArray<entEntityID> PrevTargetedEntityIDs
		{
			get
			{
				if (_prevTargetedEntityIDs == null)
				{
					_prevTargetedEntityIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "prevTargetedEntityIDs", cr2w, this);
				}
				return _prevTargetedEntityIDs;
			}
			set
			{
				if (_prevTargetedEntityIDs == value)
				{
					return;
				}
				_prevTargetedEntityIDs = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Smart_Rifl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
