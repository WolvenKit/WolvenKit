using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
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
		private inkWidgetReference _targetColorChange;
		private inkWidgetReference _middlePart;
		private inkWidgetReference _overheatShake;
		private inkWidgetReference _overheatTL;
		private inkWidgetReference _overheatBL;
		private inkWidgetReference _overheatTR;
		private inkWidgetReference _overheatBR;
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _onChargeChangeBBID;
		private CHandle<inkanimProxy> _shakeAnimation;
		private CBool _isInForcedCool;

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("middlePart")] 
		public inkWidgetReference MiddlePart
		{
			get
			{
				if (_middlePart == null)
				{
					_middlePart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "middlePart", cr2w, this);
				}
				return _middlePart;
			}
			set
			{
				if (_middlePart == value)
				{
					return;
				}
				_middlePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("overheatShake")] 
		public inkWidgetReference OverheatShake
		{
			get
			{
				if (_overheatShake == null)
				{
					_overheatShake = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatShake", cr2w, this);
				}
				return _overheatShake;
			}
			set
			{
				if (_overheatShake == value)
				{
					return;
				}
				_overheatShake = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("overheatTL")] 
		public inkWidgetReference OverheatTL
		{
			get
			{
				if (_overheatTL == null)
				{
					_overheatTL = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatTL", cr2w, this);
				}
				return _overheatTL;
			}
			set
			{
				if (_overheatTL == value)
				{
					return;
				}
				_overheatTL = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("overheatBL")] 
		public inkWidgetReference OverheatBL
		{
			get
			{
				if (_overheatBL == null)
				{
					_overheatBL = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatBL", cr2w, this);
				}
				return _overheatBL;
			}
			set
			{
				if (_overheatBL == value)
				{
					return;
				}
				_overheatBL = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("overheatTR")] 
		public inkWidgetReference OverheatTR
		{
			get
			{
				if (_overheatTR == null)
				{
					_overheatTR = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatTR", cr2w, this);
				}
				return _overheatTR;
			}
			set
			{
				if (_overheatTR == value)
				{
					return;
				}
				_overheatTR = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("overheatBR")] 
		public inkWidgetReference OverheatBR
		{
			get
			{
				if (_overheatBR == null)
				{
					_overheatBR = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "overheatBR", cr2w, this);
				}
				return _overheatBR;
			}
			set
			{
				if (_overheatBR == value)
				{
					return;
				}
				_overheatBR = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
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

		[Ordinal(37)] 
		[RED("onChargeChangeBBID")] 
		public CUInt32 OnChargeChangeBBID
		{
			get
			{
				if (_onChargeChangeBBID == null)
				{
					_onChargeChangeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "onChargeChangeBBID", cr2w, this);
				}
				return _onChargeChangeBBID;
			}
			set
			{
				if (_onChargeChangeBBID == value)
				{
					return;
				}
				_onChargeChangeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("shakeAnimation")] 
		public CHandle<inkanimProxy> ShakeAnimation
		{
			get
			{
				if (_shakeAnimation == null)
				{
					_shakeAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "shakeAnimation", cr2w, this);
				}
				return _shakeAnimation;
			}
			set
			{
				if (_shakeAnimation == value)
				{
					return;
				}
				_shakeAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("isInForcedCool")] 
		public CBool IsInForcedCool
		{
			get
			{
				if (_isInForcedCool == null)
				{
					_isInForcedCool = (CBool) CR2WTypeManager.Create("Bool", "isInForcedCool", cr2w, this);
				}
				return _isInForcedCool;
			}
			set
			{
				if (_isInForcedCool == value)
				{
					return;
				}
				_isInForcedCool = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
