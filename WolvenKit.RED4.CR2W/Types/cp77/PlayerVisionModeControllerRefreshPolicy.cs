using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerRefreshPolicy : CVariable
	{
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _kerenzikov;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _restrictedScene;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _dead;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _takedown;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _deviceTakeover;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _braindanceFPP;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _braindanceActive;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _veryHardLanding;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _noScanningRestriction;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _hasNotCybereye;
		private CEnum<PlayerVisionModeControllerRefreshPolicyEnum> _isPhotoMode;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "kerenzikov", cr2w, this);
				}
				return _kerenzikov;
			}
			set
			{
				if (_kerenzikov == value)
				{
					return;
				}
				_kerenzikov = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "restrictedScene", cr2w, this);
				}
				return _restrictedScene;
			}
			set
			{
				if (_restrictedScene == value)
				{
					return;
				}
				_restrictedScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "dead", cr2w, this);
				}
				return _dead;
			}
			set
			{
				if (_dead == value)
				{
					return;
				}
				_dead = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "takedown", cr2w, this);
				}
				return _takedown;
			}
			set
			{
				if (_takedown == value)
				{
					return;
				}
				_takedown = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "deviceTakeover", cr2w, this);
				}
				return _deviceTakeover;
			}
			set
			{
				if (_deviceTakeover == value)
				{
					return;
				}
				_deviceTakeover = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "braindanceFPP", cr2w, this);
				}
				return _braindanceFPP;
			}
			set
			{
				if (_braindanceFPP == value)
				{
					return;
				}
				_braindanceFPP = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "braindanceActive", cr2w, this);
				}
				return _braindanceActive;
			}
			set
			{
				if (_braindanceActive == value)
				{
					return;
				}
				_braindanceActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "veryHardLanding", cr2w, this);
				}
				return _veryHardLanding;
			}
			set
			{
				if (_veryHardLanding == value)
				{
					return;
				}
				_veryHardLanding = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("noScanningRestriction")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "noScanningRestriction", cr2w, this);
				}
				return _noScanningRestriction;
			}
			set
			{
				if (_noScanningRestriction == value)
				{
					return;
				}
				_noScanningRestriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hasNotCybereye")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> HasNotCybereye
		{
			get
			{
				if (_hasNotCybereye == null)
				{
					_hasNotCybereye = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "hasNotCybereye", cr2w, this);
				}
				return _hasNotCybereye;
			}
			set
			{
				if (_hasNotCybereye == value)
				{
					return;
				}
				_hasNotCybereye = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isPhotoMode")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> IsPhotoMode
		{
			get
			{
				if (_isPhotoMode == null)
				{
					_isPhotoMode = (CEnum<PlayerVisionModeControllerRefreshPolicyEnum>) CR2WTypeManager.Create("PlayerVisionModeControllerRefreshPolicyEnum", "isPhotoMode", cr2w, this);
				}
				return _isPhotoMode;
			}
			set
			{
				if (_isPhotoMode == value)
				{
					return;
				}
				_isPhotoMode = value;
				PropertySet(this);
			}
		}

		public PlayerVisionModeControllerRefreshPolicy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
