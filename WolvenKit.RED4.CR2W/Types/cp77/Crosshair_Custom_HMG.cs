using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Custom_HMG : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _topPart;
		private inkWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private inkWidgetReference _overheatContainer;
		private inkWidgetReference _overheatWarning;
		private inkWidgetReference _overheatMask;
		private inkTextWidgetReference _overheatValueL;
		private inkTextWidgetReference _overheatValueR;
		private inkImageWidgetReference _leftPartExtra;
		private inkImageWidgetReference _rightPartExtra;
		private inkCanvasWidgetReference _crosshairContainer;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _overheatBBID;
		private CUInt32 _forcedOverheatBBID;
		private inkWidgetReference _targetColorChange;
		private CHandle<inkanimProxy> _forcedCooldownProxy;
		private inkanimPlaybackOptions _forcedCooldownOptions;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftPart", cr2w, this);
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

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightPart", cr2w, this);
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

		[Ordinal(20)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get
			{
				if (_topPart == null)
				{
					_topPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "topPart", cr2w, this);
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

		[Ordinal(21)] 
		[RED("bottomPart")] 
		public inkWidgetReference BottomPart
		{
			get
			{
				if (_bottomPart == null)
				{
					_bottomPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bottomPart", cr2w, this);
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
		[RED("overheatContainer")] 
		public inkWidgetReference OverheatContainer
		{
			get
			{
				if (_overheatContainer == null)
				{
					_overheatContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatContainer", cr2w, this);
				}
				return _overheatContainer;
			}
			set
			{
				if (_overheatContainer == value)
				{
					return;
				}
				_overheatContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("overheatWarning")] 
		public inkWidgetReference OverheatWarning
		{
			get
			{
				if (_overheatWarning == null)
				{
					_overheatWarning = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatWarning", cr2w, this);
				}
				return _overheatWarning;
			}
			set
			{
				if (_overheatWarning == value)
				{
					return;
				}
				_overheatWarning = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("overheatMask")] 
		public inkWidgetReference OverheatMask
		{
			get
			{
				if (_overheatMask == null)
				{
					_overheatMask = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatMask", cr2w, this);
				}
				return _overheatMask;
			}
			set
			{
				if (_overheatMask == value)
				{
					return;
				}
				_overheatMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("overheatValueL")] 
		public inkTextWidgetReference OverheatValueL
		{
			get
			{
				if (_overheatValueL == null)
				{
					_overheatValueL = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "overheatValueL", cr2w, this);
				}
				return _overheatValueL;
			}
			set
			{
				if (_overheatValueL == value)
				{
					return;
				}
				_overheatValueL = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("overheatValueR")] 
		public inkTextWidgetReference OverheatValueR
		{
			get
			{
				if (_overheatValueR == null)
				{
					_overheatValueR = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "overheatValueR", cr2w, this);
				}
				return _overheatValueR;
			}
			set
			{
				if (_overheatValueR == value)
				{
					return;
				}
				_overheatValueR = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
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

		[Ordinal(30)] 
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

		[Ordinal(31)] 
		[RED("crosshairContainer")] 
		public inkCanvasWidgetReference CrosshairContainer
		{
			get
			{
				if (_crosshairContainer == null)
				{
					_crosshairContainer = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "crosshairContainer", cr2w, this);
				}
				return _crosshairContainer;
			}
			set
			{
				if (_crosshairContainer == value)
				{
					return;
				}
				_crosshairContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		[Ordinal(34)] 
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

		[Ordinal(35)] 
		[RED("weaponLocalBB")] 
		public CHandle<gameIBlackboard> WeaponLocalBB
		{
			get
			{
				if (_weaponLocalBB == null)
				{
					_weaponLocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponLocalBB", cr2w, this);
				}
				return _weaponLocalBB;
			}
			set
			{
				if (_weaponLocalBB == value)
				{
					return;
				}
				_weaponLocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("overheatBBID")] 
		public CUInt32 OverheatBBID
		{
			get
			{
				if (_overheatBBID == null)
				{
					_overheatBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "overheatBBID", cr2w, this);
				}
				return _overheatBBID;
			}
			set
			{
				if (_overheatBBID == value)
				{
					return;
				}
				_overheatBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("forcedOverheatBBID")] 
		public CUInt32 ForcedOverheatBBID
		{
			get
			{
				if (_forcedOverheatBBID == null)
				{
					_forcedOverheatBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "forcedOverheatBBID", cr2w, this);
				}
				return _forcedOverheatBBID;
			}
			set
			{
				if (_forcedOverheatBBID == value)
				{
					return;
				}
				_forcedOverheatBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
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

		[Ordinal(39)] 
		[RED("forcedCooldownProxy")] 
		public CHandle<inkanimProxy> ForcedCooldownProxy
		{
			get
			{
				if (_forcedCooldownProxy == null)
				{
					_forcedCooldownProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "forcedCooldownProxy", cr2w, this);
				}
				return _forcedCooldownProxy;
			}
			set
			{
				if (_forcedCooldownProxy == value)
				{
					return;
				}
				_forcedCooldownProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("forcedCooldownOptions")] 
		public inkanimPlaybackOptions ForcedCooldownOptions
		{
			get
			{
				if (_forcedCooldownOptions == null)
				{
					_forcedCooldownOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "forcedCooldownOptions", cr2w, this);
				}
				return _forcedCooldownOptions;
			}
			set
			{
				if (_forcedCooldownOptions == value)
				{
					return;
				}
				_forcedCooldownOptions = value;
				PropertySet(this);
			}
		}

		public Crosshair_Custom_HMG(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
