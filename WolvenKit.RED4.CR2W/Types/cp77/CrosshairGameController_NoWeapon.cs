using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
	{
		private inkCompoundWidgetReference _aimDownSightContainer;
		private inkCompoundWidgetReference _zoomMovingContainer;
		private inkTextWidgetReference _zoomNumber;
		private inkTextWidgetReference _zoomNumberR;
		private inkImageWidgetReference _distanceImageRuler;
		private inkImageWidgetReference _zoomMoveBracketL;
		private inkImageWidgetReference _zoomMoveBracketR;
		private CString _zoomLevelString;
		private CHandle<gameIBlackboard> _playerSMBB;
		private CUInt32 _zoomLevelBBID;
		private CUInt32 _sceneTierBlackboardId;
		private CEnum<gamePSMHighLevel> _sceneTier;
		private CHandle<inkanimProxy> _zoomUpAnim;
		private CHandle<inkanimProxy> _animLockOn;
		private CHandle<inkanimProxy> _zoomDownAnim;
		private CHandle<inkanimProxy> _animLockOff;
		private CHandle<inkanimProxy> _zoomShowAnim;
		private CHandle<inkanimProxy> _zoomHideAnim;
		private CFloat _argZoomBuffered;

		[Ordinal(18)] 
		[RED("AimDownSightContainer")] 
		public inkCompoundWidgetReference AimDownSightContainer
		{
			get
			{
				if (_aimDownSightContainer == null)
				{
					_aimDownSightContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "AimDownSightContainer", cr2w, this);
				}
				return _aimDownSightContainer;
			}
			set
			{
				if (_aimDownSightContainer == value)
				{
					return;
				}
				_aimDownSightContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("ZoomMovingContainer")] 
		public inkCompoundWidgetReference ZoomMovingContainer
		{
			get
			{
				if (_zoomMovingContainer == null)
				{
					_zoomMovingContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ZoomMovingContainer", cr2w, this);
				}
				return _zoomMovingContainer;
			}
			set
			{
				if (_zoomMovingContainer == value)
				{
					return;
				}
				_zoomMovingContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get
			{
				if (_zoomNumber == null)
				{
					_zoomNumber = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ZoomNumber", cr2w, this);
				}
				return _zoomNumber;
			}
			set
			{
				if (_zoomNumber == value)
				{
					return;
				}
				_zoomNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ZoomNumberR")] 
		public inkTextWidgetReference ZoomNumberR
		{
			get
			{
				if (_zoomNumberR == null)
				{
					_zoomNumberR = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ZoomNumberR", cr2w, this);
				}
				return _zoomNumberR;
			}
			set
			{
				if (_zoomNumberR == value)
				{
					return;
				}
				_zoomNumberR = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get
			{
				if (_distanceImageRuler == null)
				{
					_distanceImageRuler = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "DistanceImageRuler", cr2w, this);
				}
				return _distanceImageRuler;
			}
			set
			{
				if (_distanceImageRuler == value)
				{
					return;
				}
				_distanceImageRuler = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get
			{
				if (_zoomMoveBracketL == null)
				{
					_zoomMoveBracketL = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ZoomMoveBracketL", cr2w, this);
				}
				return _zoomMoveBracketL;
			}
			set
			{
				if (_zoomMoveBracketL == value)
				{
					return;
				}
				_zoomMoveBracketL = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get
			{
				if (_zoomMoveBracketR == null)
				{
					_zoomMoveBracketR = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ZoomMoveBracketR", cr2w, this);
				}
				return _zoomMoveBracketR;
			}
			set
			{
				if (_zoomMoveBracketR == value)
				{
					return;
				}
				_zoomMoveBracketR = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("ZoomLevelString")] 
		public CString ZoomLevelString
		{
			get
			{
				if (_zoomLevelString == null)
				{
					_zoomLevelString = (CString) CR2WTypeManager.Create("String", "ZoomLevelString", cr2w, this);
				}
				return _zoomLevelString;
			}
			set
			{
				if (_zoomLevelString == value)
				{
					return;
				}
				_zoomLevelString = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("PlayerSMBB")] 
		public CHandle<gameIBlackboard> PlayerSMBB
		{
			get
			{
				if (_playerSMBB == null)
				{
					_playerSMBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "PlayerSMBB", cr2w, this);
				}
				return _playerSMBB;
			}
			set
			{
				if (_playerSMBB == value)
				{
					return;
				}
				_playerSMBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("ZoomLevelBBID")] 
		public CUInt32 ZoomLevelBBID
		{
			get
			{
				if (_zoomLevelBBID == null)
				{
					_zoomLevelBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "ZoomLevelBBID", cr2w, this);
				}
				return _zoomLevelBBID;
			}
			set
			{
				if (_zoomLevelBBID == value)
				{
					return;
				}
				_zoomLevelBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("sceneTierBlackboardId")] 
		public CUInt32 SceneTierBlackboardId
		{
			get
			{
				if (_sceneTierBlackboardId == null)
				{
					_sceneTierBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "sceneTierBlackboardId", cr2w, this);
				}
				return _sceneTierBlackboardId;
			}
			set
			{
				if (_sceneTierBlackboardId == value)
				{
					return;
				}
				_sceneTierBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("sceneTier")] 
		public CEnum<gamePSMHighLevel> SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (CEnum<gamePSMHighLevel>) CR2WTypeManager.Create("gamePSMHighLevel", "sceneTier", cr2w, this);
				}
				return _sceneTier;
			}
			set
			{
				if (_sceneTier == value)
				{
					return;
				}
				_sceneTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get
			{
				if (_zoomUpAnim == null)
				{
					_zoomUpAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomUpAnim", cr2w, this);
				}
				return _zoomUpAnim;
			}
			set
			{
				if (_zoomUpAnim == value)
				{
					return;
				}
				_zoomUpAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get
			{
				if (_animLockOn == null)
				{
					_animLockOn = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLockOn", cr2w, this);
				}
				return _animLockOn;
			}
			set
			{
				if (_animLockOn == value)
				{
					return;
				}
				_animLockOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get
			{
				if (_zoomDownAnim == null)
				{
					_zoomDownAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomDownAnim", cr2w, this);
				}
				return _zoomDownAnim;
			}
			set
			{
				if (_zoomDownAnim == value)
				{
					return;
				}
				_zoomDownAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get
			{
				if (_animLockOff == null)
				{
					_animLockOff = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animLockOff", cr2w, this);
				}
				return _animLockOff;
			}
			set
			{
				if (_animLockOff == value)
				{
					return;
				}
				_animLockOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("zoomShowAnim")] 
		public CHandle<inkanimProxy> ZoomShowAnim
		{
			get
			{
				if (_zoomShowAnim == null)
				{
					_zoomShowAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomShowAnim", cr2w, this);
				}
				return _zoomShowAnim;
			}
			set
			{
				if (_zoomShowAnim == value)
				{
					return;
				}
				_zoomShowAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("zoomHideAnim")] 
		public CHandle<inkanimProxy> ZoomHideAnim
		{
			get
			{
				if (_zoomHideAnim == null)
				{
					_zoomHideAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "zoomHideAnim", cr2w, this);
				}
				return _zoomHideAnim;
			}
			set
			{
				if (_zoomHideAnim == value)
				{
					return;
				}
				_zoomHideAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get
			{
				if (_argZoomBuffered == null)
				{
					_argZoomBuffered = (CFloat) CR2WTypeManager.Create("Float", "argZoomBuffered", cr2w, this);
				}
				return _argZoomBuffered;
			}
			set
			{
				if (_argZoomBuffered == value)
				{
					return;
				}
				_argZoomBuffered = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
