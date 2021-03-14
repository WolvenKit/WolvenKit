using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		private wCHandle<inkImageWidget> _leftBracket;
		private wCHandle<inkImageWidget> _rightBracket;
		private wCHandle<inkWidget> _hori;
		private wCHandle<inkWidget> _chargeBar;
		private wCHandle<inkWidget> _ammoLeft;
		private wCHandle<inkWidget> _ammoRight;
		private wCHandle<inkWidget> _ammoLeftFill;
		private wCHandle<inkWidget> _ammoRightFill;
		private wCHandle<inkWidget> _chargeBoth;
		private wCHandle<inkRectangleWidget> _chargeLeftBar;
		private wCHandle<inkRectangleWidget> _chargeRightBar;
		private wCHandle<inkImageWidget> _centerPart;
		private wCHandle<inkWidget> _fluffCanvas;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CUInt32 _bbcharge;
		private CUInt32 _bbmagazineAmmoCount;
		private CUInt32 _bbcurrentFireMode;
		private CInt32 _currentAmmo;
		private CInt32 _currentMaxAmmo;
		private CInt32 _maxSupportedAmmo;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private CUInt32 _bbNPCStatsInfo;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CFloat _charge;
		private CFloat _spread;

		[Ordinal(24)] 
		[RED("leftBracket")] 
		public wCHandle<inkImageWidget> LeftBracket
		{
			get
			{
				if (_leftBracket == null)
				{
					_leftBracket = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "leftBracket", cr2w, this);
				}
				return _leftBracket;
			}
			set
			{
				if (_leftBracket == value)
				{
					return;
				}
				_leftBracket = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("rightBracket")] 
		public wCHandle<inkImageWidget> RightBracket
		{
			get
			{
				if (_rightBracket == null)
				{
					_rightBracket = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "rightBracket", cr2w, this);
				}
				return _rightBracket;
			}
			set
			{
				if (_rightBracket == value)
				{
					return;
				}
				_rightBracket = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("hori")] 
		public wCHandle<inkWidget> Hori
		{
			get
			{
				if (_hori == null)
				{
					_hori = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "hori", cr2w, this);
				}
				return _hori;
			}
			set
			{
				if (_hori == value)
				{
					return;
				}
				_hori = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("chargeBar")] 
		public wCHandle<inkWidget> ChargeBar
		{
			get
			{
				if (_chargeBar == null)
				{
					_chargeBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeBar", cr2w, this);
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

		[Ordinal(28)] 
		[RED("ammoLeft")] 
		public wCHandle<inkWidget> AmmoLeft
		{
			get
			{
				if (_ammoLeft == null)
				{
					_ammoLeft = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ammoLeft", cr2w, this);
				}
				return _ammoLeft;
			}
			set
			{
				if (_ammoLeft == value)
				{
					return;
				}
				_ammoLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("ammoRight")] 
		public wCHandle<inkWidget> AmmoRight
		{
			get
			{
				if (_ammoRight == null)
				{
					_ammoRight = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ammoRight", cr2w, this);
				}
				return _ammoRight;
			}
			set
			{
				if (_ammoRight == value)
				{
					return;
				}
				_ammoRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ammoLeftFill")] 
		public wCHandle<inkWidget> AmmoLeftFill
		{
			get
			{
				if (_ammoLeftFill == null)
				{
					_ammoLeftFill = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ammoLeftFill", cr2w, this);
				}
				return _ammoLeftFill;
			}
			set
			{
				if (_ammoLeftFill == value)
				{
					return;
				}
				_ammoLeftFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("ammoRightFill")] 
		public wCHandle<inkWidget> AmmoRightFill
		{
			get
			{
				if (_ammoRightFill == null)
				{
					_ammoRightFill = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ammoRightFill", cr2w, this);
				}
				return _ammoRightFill;
			}
			set
			{
				if (_ammoRightFill == value)
				{
					return;
				}
				_ammoRightFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("chargeBoth")] 
		public wCHandle<inkWidget> ChargeBoth
		{
			get
			{
				if (_chargeBoth == null)
				{
					_chargeBoth = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeBoth", cr2w, this);
				}
				return _chargeBoth;
			}
			set
			{
				if (_chargeBoth == value)
				{
					return;
				}
				_chargeBoth = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("chargeLeftBar")] 
		public wCHandle<inkRectangleWidget> ChargeLeftBar
		{
			get
			{
				if (_chargeLeftBar == null)
				{
					_chargeLeftBar = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeLeftBar", cr2w, this);
				}
				return _chargeLeftBar;
			}
			set
			{
				if (_chargeLeftBar == value)
				{
					return;
				}
				_chargeLeftBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("chargeRightBar")] 
		public wCHandle<inkRectangleWidget> ChargeRightBar
		{
			get
			{
				if (_chargeRightBar == null)
				{
					_chargeRightBar = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeRightBar", cr2w, this);
				}
				return _chargeRightBar;
			}
			set
			{
				if (_chargeRightBar == value)
				{
					return;
				}
				_chargeRightBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("centerPart")] 
		public wCHandle<inkImageWidget> CenterPart
		{
			get
			{
				if (_centerPart == null)
				{
					_centerPart = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "centerPart", cr2w, this);
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

		[Ordinal(36)] 
		[RED("fluffCanvas")] 
		public wCHandle<inkWidget> FluffCanvas
		{
			get
			{
				if (_fluffCanvas == null)
				{
					_fluffCanvas = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "fluffCanvas", cr2w, this);
				}
				return _fluffCanvas;
			}
			set
			{
				if (_fluffCanvas == value)
				{
					return;
				}
				_fluffCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
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

		[Ordinal(38)] 
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

		[Ordinal(39)] 
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

		[Ordinal(40)] 
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

		[Ordinal(41)] 
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

		[Ordinal(42)] 
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

		[Ordinal(43)] 
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

		[Ordinal(44)] 
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

		[Ordinal(45)] 
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

		[Ordinal(46)] 
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

		[Ordinal(47)] 
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

		[Ordinal(48)] 
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

		[Ordinal(49)] 
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

		[Ordinal(50)] 
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

		[Ordinal(51)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (CFloat) CR2WTypeManager.Create("Float", "charge", cr2w, this);
				}
				return _charge;
			}
			set
			{
				if (_charge == value)
				{
					return;
				}
				_charge = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get
			{
				if (_spread == null)
				{
					_spread = (CFloat) CR2WTypeManager.Create("Float", "spread", cr2w, this);
				}
				return _spread;
			}
			set
			{
				if (_spread == value)
				{
					return;
				}
				_spread = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Tech_Hex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
