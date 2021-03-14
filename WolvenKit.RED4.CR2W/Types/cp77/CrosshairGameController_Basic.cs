using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
	{
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private inkImageWidgetReference _upPart;
		private inkImageWidgetReference _downPart;
		private inkImageWidgetReference _centerPart;
		private Vector2 _bufferedSpread;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CUInt32 _bbcurrentFireMode;
		private CUInt32 _ricochetModeActive;
		private CUInt32 _ricochetChance;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;

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
		[RED("upPart")] 
		public inkImageWidgetReference UpPart
		{
			get
			{
				if (_upPart == null)
				{
					_upPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "upPart", cr2w, this);
				}
				return _upPart;
			}
			set
			{
				if (_upPart == value)
				{
					return;
				}
				_upPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("downPart")] 
		public inkImageWidgetReference DownPart
		{
			get
			{
				if (_downPart == null)
				{
					_downPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "downPart", cr2w, this);
				}
				return _downPart;
			}
			set
			{
				if (_downPart == value)
				{
					return;
				}
				_downPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("centerPart")] 
		public inkImageWidgetReference CenterPart
		{
			get
			{
				if (_centerPart == null)
				{
					_centerPart = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "centerPart", cr2w, this);
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
		[RED("ricochetModeActive")] 
		public CUInt32 RicochetModeActive
		{
			get
			{
				if (_ricochetModeActive == null)
				{
					_ricochetModeActive = (CUInt32) CR2WTypeManager.Create("Uint32", "ricochetModeActive", cr2w, this);
				}
				return _ricochetModeActive;
			}
			set
			{
				if (_ricochetModeActive == value)
				{
					return;
				}
				_ricochetModeActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("RicochetChance")] 
		public CUInt32 RicochetChance
		{
			get
			{
				if (_ricochetChance == null)
				{
					_ricochetChance = (CUInt32) CR2WTypeManager.Create("Uint32", "RicochetChance", cr2w, this);
				}
				return _ricochetChance;
			}
			set
			{
				if (_ricochetChance == value)
				{
					return;
				}
				_ricochetChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
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

		[Ordinal(31)] 
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

		[Ordinal(32)] 
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

		public CrosshairGameController_Basic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
