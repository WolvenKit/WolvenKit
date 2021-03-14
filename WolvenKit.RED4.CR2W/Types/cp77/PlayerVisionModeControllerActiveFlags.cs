using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerActiveFlags : CVariable
	{
		private CBool _kerenzikov;
		private CBool _restrictedScene;
		private CBool _dead;
		private CBool _takedown;
		private CBool _deviceTakeover;
		private CBool _braindanceFPP;
		private CBool _braindanceActive;
		private CBool _veryHardLanding;
		private CBool _noScanningRestriction;
		private CBool _hasNotCybereye;
		private CBool _isPhotoMode;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CBool Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (CBool) CR2WTypeManager.Create("Bool", "kerenzikov", cr2w, this);
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
		public CBool RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (CBool) CR2WTypeManager.Create("Bool", "restrictedScene", cr2w, this);
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
		public CBool Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (CBool) CR2WTypeManager.Create("Bool", "dead", cr2w, this);
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
		public CBool Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (CBool) CR2WTypeManager.Create("Bool", "takedown", cr2w, this);
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
		public CBool DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (CBool) CR2WTypeManager.Create("Bool", "deviceTakeover", cr2w, this);
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
		public CBool BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (CBool) CR2WTypeManager.Create("Bool", "braindanceFPP", cr2w, this);
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
		public CBool BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (CBool) CR2WTypeManager.Create("Bool", "braindanceActive", cr2w, this);
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
		public CBool VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (CBool) CR2WTypeManager.Create("Bool", "veryHardLanding", cr2w, this);
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
		public CBool NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (CBool) CR2WTypeManager.Create("Bool", "noScanningRestriction", cr2w, this);
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
		public CBool HasNotCybereye
		{
			get
			{
				if (_hasNotCybereye == null)
				{
					_hasNotCybereye = (CBool) CR2WTypeManager.Create("Bool", "hasNotCybereye", cr2w, this);
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
		public CBool IsPhotoMode
		{
			get
			{
				if (_isPhotoMode == null)
				{
					_isPhotoMode = (CBool) CR2WTypeManager.Create("Bool", "isPhotoMode", cr2w, this);
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

		public PlayerVisionModeControllerActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
