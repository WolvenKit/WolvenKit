using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Round : BaseTechCrosshairController
	{
		private wCHandle<inkWidget> _root;
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private inkImageWidgetReference _topPart;
		private inkImageWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private wCHandle<inkCanvasWidget> _chargeBar;
		private wCHandle<inkRectangleWidget> _chargeBarFG;
		private wCHandle<inkRectangleWidget> _chargeBarBG;
		private wCHandle<inkRectangleWidget> _chargeBarMG;
		private wCHandle<inkWidget> _centerPart;
		private wCHandle<inkWidget> _bottom_hip_bar;
		private wCHandle<inkTextWidget> _realFluffText_1;
		private wCHandle<inkTextWidget> _realFluffText_2;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CUInt32 _bbcharge;
		private CUInt32 _bbmagazineAmmoCapacity;
		private CUInt32 _bbmagazineAmmoCount;
		private CUInt32 _bbcurrentFireMode;
		private CInt32 _currentAmmo;
		private CInt32 _currentMaxAmmo;
		private CInt32 _maxSupportedAmmo;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private Vector2 _orgSideSize;
		private CFloat _sidesScale;
		private CUInt32 _bbNPCStatsInfo;
		private CUInt32 _currentObstructedTargetBBID;
		private wCHandle<gameObject> _potentialVisibleTarget;
		private wCHandle<gameObject> _potentialObstructedTarget;
		private CBool _useVisibleTarget;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private CFloat _spreadRA;

		[Ordinal(24)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
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

		[Ordinal(31)] 
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

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		[Ordinal(34)] 
		[RED("chargeBar")] 
		public wCHandle<inkCanvasWidget> ChargeBar
		{
			get
			{
				if (_chargeBar == null)
				{
					_chargeBar = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "chargeBar", cr2w, this);
				}
				return _chargeBar;
			}
			set
			{
				if (_chargeBar == value)
				{
					return;
				}
				_chargeBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("chargeBarFG")] 
		public wCHandle<inkRectangleWidget> ChargeBarFG
		{
			get
			{
				if (_chargeBarFG == null)
				{
					_chargeBarFG = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeBarFG", cr2w, this);
				}
				return _chargeBarFG;
			}
			set
			{
				if (_chargeBarFG == value)
				{
					return;
				}
				_chargeBarFG = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("chargeBarBG")] 
		public wCHandle<inkRectangleWidget> ChargeBarBG
		{
			get
			{
				if (_chargeBarBG == null)
				{
					_chargeBarBG = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeBarBG", cr2w, this);
				}
				return _chargeBarBG;
			}
			set
			{
				if (_chargeBarBG == value)
				{
					return;
				}
				_chargeBarBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("chargeBarMG")] 
		public wCHandle<inkRectangleWidget> ChargeBarMG
		{
			get
			{
				if (_chargeBarMG == null)
				{
					_chargeBarMG = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeBarMG", cr2w, this);
				}
				return _chargeBarMG;
			}
			set
			{
				if (_chargeBarMG == value)
				{
					return;
				}
				_chargeBarMG = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("centerPart")] 
		public wCHandle<inkWidget> CenterPart
		{
			get
			{
				if (_centerPart == null)
				{
					_centerPart = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "centerPart", cr2w, this);
				}
				return _centerPart;
			}
			set
			{
				if (_centerPart == value)
				{
					return;
				}
				_centerPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("bottom_hip_bar")] 
		public wCHandle<inkWidget> Bottom_hip_bar
		{
			get
			{
				if (_bottom_hip_bar == null)
				{
					_bottom_hip_bar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "bottom_hip_bar", cr2w, this);
				}
				return _bottom_hip_bar;
			}
			set
			{
				if (_bottom_hip_bar == value)
				{
					return;
				}
				_bottom_hip_bar = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("realFluffText_1")] 
		public wCHandle<inkTextWidget> RealFluffText_1
		{
			get
			{
				if (_realFluffText_1 == null)
				{
					_realFluffText_1 = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "realFluffText_1", cr2w, this);
				}
				return _realFluffText_1;
			}
			set
			{
				if (_realFluffText_1 == value)
				{
					return;
				}
				_realFluffText_1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("realFluffText_2")] 
		public wCHandle<inkTextWidget> RealFluffText_2
		{
			get
			{
				if (_realFluffText_2 == null)
				{
					_realFluffText_2 = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "realFluffText_2", cr2w, this);
				}
				return _realFluffText_2;
			}
			set
			{
				if (_realFluffText_2 == value)
				{
					return;
				}
				_realFluffText_2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
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

		[Ordinal(43)] 
		[RED("weaponlocalBB")] 
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get
			{
				if (_weaponlocalBB == null)
				{
					_weaponlocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponlocalBB", cr2w, this);
				}
				return _weaponlocalBB;
			}
			set
			{
				if (_weaponlocalBB == value)
				{
					return;
				}
				_weaponlocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get
			{
				if (_bbcharge == null)
				{
					_bbcharge = (CUInt32) CR2WTypeManager.Create("Uint32", "bbcharge", cr2w, this);
				}
				return _bbcharge;
			}
			set
			{
				if (_bbcharge == value)
				{
					return;
				}
				_bbcharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("bbmagazineAmmoCapacity")] 
		public CUInt32 BbmagazineAmmoCapacity
		{
			get
			{
				if (_bbmagazineAmmoCapacity == null)
				{
					_bbmagazineAmmoCapacity = (CUInt32) CR2WTypeManager.Create("Uint32", "bbmagazineAmmoCapacity", cr2w, this);
				}
				return _bbmagazineAmmoCapacity;
			}
			set
			{
				if (_bbmagazineAmmoCapacity == value)
				{
					return;
				}
				_bbmagazineAmmoCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("bbmagazineAmmoCount")] 
		public CUInt32 BbmagazineAmmoCount
		{
			get
			{
				if (_bbmagazineAmmoCount == null)
				{
					_bbmagazineAmmoCount = (CUInt32) CR2WTypeManager.Create("Uint32", "bbmagazineAmmoCount", cr2w, this);
				}
				return _bbmagazineAmmoCount;
			}
			set
			{
				if (_bbmagazineAmmoCount == value)
				{
					return;
				}
				_bbmagazineAmmoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("bbcurrentFireMode")] 
		public CUInt32 BbcurrentFireMode
		{
			get
			{
				if (_bbcurrentFireMode == null)
				{
					_bbcurrentFireMode = (CUInt32) CR2WTypeManager.Create("Uint32", "bbcurrentFireMode", cr2w, this);
				}
				return _bbcurrentFireMode;
			}
			set
			{
				if (_bbcurrentFireMode == value)
				{
					return;
				}
				_bbcurrentFireMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get
			{
				if (_currentAmmo == null)
				{
					_currentAmmo = (CInt32) CR2WTypeManager.Create("Int32", "currentAmmo", cr2w, this);
				}
				return _currentAmmo;
			}
			set
			{
				if (_currentAmmo == value)
				{
					return;
				}
				_currentAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("currentMaxAmmo")] 
		public CInt32 CurrentMaxAmmo
		{
			get
			{
				if (_currentMaxAmmo == null)
				{
					_currentMaxAmmo = (CInt32) CR2WTypeManager.Create("Int32", "currentMaxAmmo", cr2w, this);
				}
				return _currentMaxAmmo;
			}
			set
			{
				if (_currentMaxAmmo == value)
				{
					return;
				}
				_currentMaxAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("maxSupportedAmmo")] 
		public CInt32 MaxSupportedAmmo
		{
			get
			{
				if (_maxSupportedAmmo == null)
				{
					_maxSupportedAmmo = (CInt32) CR2WTypeManager.Create("Int32", "maxSupportedAmmo", cr2w, this);
				}
				return _maxSupportedAmmo;
			}
			set
			{
				if (_maxSupportedAmmo == value)
				{
					return;
				}
				_maxSupportedAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get
			{
				if (_currentFireMode == null)
				{
					_currentFireMode = (CEnum<gamedataTriggerMode>) CR2WTypeManager.Create("gamedataTriggerMode", "currentFireMode", cr2w, this);
				}
				return _currentFireMode;
			}
			set
			{
				if (_currentFireMode == value)
				{
					return;
				}
				_currentFireMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get
			{
				if (_orgSideSize == null)
				{
					_orgSideSize = (Vector2) CR2WTypeManager.Create("Vector2", "orgSideSize", cr2w, this);
				}
				return _orgSideSize;
			}
			set
			{
				if (_orgSideSize == value)
				{
					return;
				}
				_orgSideSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("sidesScale")] 
		public CFloat SidesScale
		{
			get
			{
				if (_sidesScale == null)
				{
					_sidesScale = (CFloat) CR2WTypeManager.Create("Float", "sidesScale", cr2w, this);
				}
				return _sidesScale;
			}
			set
			{
				if (_sidesScale == value)
				{
					return;
				}
				_sidesScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("bbNPCStatsInfo")] 
		public CUInt32 BbNPCStatsInfo
		{
			get
			{
				if (_bbNPCStatsInfo == null)
				{
					_bbNPCStatsInfo = (CUInt32) CR2WTypeManager.Create("Uint32", "bbNPCStatsInfo", cr2w, this);
				}
				return _bbNPCStatsInfo;
			}
			set
			{
				if (_bbNPCStatsInfo == value)
				{
					return;
				}
				_bbNPCStatsInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("currentObstructedTargetBBID")] 
		public CUInt32 CurrentObstructedTargetBBID
		{
			get
			{
				if (_currentObstructedTargetBBID == null)
				{
					_currentObstructedTargetBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentObstructedTargetBBID", cr2w, this);
				}
				return _currentObstructedTargetBBID;
			}
			set
			{
				if (_currentObstructedTargetBBID == value)
				{
					return;
				}
				_currentObstructedTargetBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("potentialVisibleTarget")] 
		public wCHandle<gameObject> PotentialVisibleTarget
		{
			get
			{
				if (_potentialVisibleTarget == null)
				{
					_potentialVisibleTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "potentialVisibleTarget", cr2w, this);
				}
				return _potentialVisibleTarget;
			}
			set
			{
				if (_potentialVisibleTarget == value)
				{
					return;
				}
				_potentialVisibleTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("potentialObstructedTarget")] 
		public wCHandle<gameObject> PotentialObstructedTarget
		{
			get
			{
				if (_potentialObstructedTarget == null)
				{
					_potentialObstructedTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "potentialObstructedTarget", cr2w, this);
				}
				return _potentialObstructedTarget;
			}
			set
			{
				if (_potentialObstructedTarget == value)
				{
					return;
				}
				_potentialObstructedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("useVisibleTarget")] 
		public CBool UseVisibleTarget
		{
			get
			{
				if (_useVisibleTarget == null)
				{
					_useVisibleTarget = (CBool) CR2WTypeManager.Create("Bool", "useVisibleTarget", cr2w, this);
				}
				return _useVisibleTarget;
			}
			set
			{
				if (_useVisibleTarget == value)
				{
					return;
				}
				_useVisibleTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get
			{
				if (_horizontalMinSpread == null)
				{
					_horizontalMinSpread = (CFloat) CR2WTypeManager.Create("Float", "horizontalMinSpread", cr2w, this);
				}
				return _horizontalMinSpread;
			}
			set
			{
				if (_horizontalMinSpread == value)
				{
					return;
				}
				_horizontalMinSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get
			{
				if (_verticalMinSpread == null)
				{
					_verticalMinSpread = (CFloat) CR2WTypeManager.Create("Float", "verticalMinSpread", cr2w, this);
				}
				return _verticalMinSpread;
			}
			set
			{
				if (_verticalMinSpread == value)
				{
					return;
				}
				_verticalMinSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get
			{
				if (_gameplaySpreadMultiplier == null)
				{
					_gameplaySpreadMultiplier = (CFloat) CR2WTypeManager.Create("Float", "gameplaySpreadMultiplier", cr2w, this);
				}
				return _gameplaySpreadMultiplier;
			}
			set
			{
				if (_gameplaySpreadMultiplier == value)
				{
					return;
				}
				_gameplaySpreadMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get
			{
				if (_chargeAnimationProxy == null)
				{
					_chargeAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "chargeAnimationProxy", cr2w, this);
				}
				return _chargeAnimationProxy;
			}
			set
			{
				if (_chargeAnimationProxy == value)
				{
					return;
				}
				_chargeAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("spreadRA")] 
		public CFloat SpreadRA
		{
			get
			{
				if (_spreadRA == null)
				{
					_spreadRA = (CFloat) CR2WTypeManager.Create("Float", "spreadRA", cr2w, this);
				}
				return _spreadRA;
			}
			set
			{
				if (_spreadRA == value)
				{
					return;
				}
				_spreadRA = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Tech_Round(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
