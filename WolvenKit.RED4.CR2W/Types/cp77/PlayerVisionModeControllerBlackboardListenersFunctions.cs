using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBlackboardListenersFunctions : CVariable
	{
		private CName _kerenzikov;
		private CName _restrictedScene;
		private CName _dead;
		private CName _takedown;
		private CName _deviceTakeover;
		private CName _braindanceFPP;
		private CName _braindanceActive;
		private CName _veryHardLanding;
		private CName _noScanningRestriction;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CName Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (CName) CR2WTypeManager.Create("CName", "kerenzikov", cr2w, this);
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
		public CName RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (CName) CR2WTypeManager.Create("CName", "restrictedScene", cr2w, this);
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
		public CName Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (CName) CR2WTypeManager.Create("CName", "dead", cr2w, this);
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
		public CName Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (CName) CR2WTypeManager.Create("CName", "takedown", cr2w, this);
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
		public CName DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (CName) CR2WTypeManager.Create("CName", "deviceTakeover", cr2w, this);
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
		public CName BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (CName) CR2WTypeManager.Create("CName", "braindanceFPP", cr2w, this);
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
		public CName BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (CName) CR2WTypeManager.Create("CName", "braindanceActive", cr2w, this);
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
		public CName VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (CName) CR2WTypeManager.Create("CName", "veryHardLanding", cr2w, this);
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
		public CName NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (CName) CR2WTypeManager.Create("CName", "noScanningRestriction", cr2w, this);
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

		public PlayerVisionModeControllerBlackboardListenersFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
