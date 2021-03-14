using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBListeners : CVariable
	{
		private CUInt32 _kerenzikov;
		private CUInt32 _restrictedScene;
		private CUInt32 _dead;
		private CUInt32 _takedown;
		private CUInt32 _deviceTakeover;
		private CUInt32 _braindanceFPP;
		private CUInt32 _braindanceActive;
		private CUInt32 _veryHardLanding;
		private CUInt32 _noScanningRestriction;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CUInt32 Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (CUInt32) CR2WTypeManager.Create("Uint32", "kerenzikov", cr2w, this);
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
		public CUInt32 RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (CUInt32) CR2WTypeManager.Create("Uint32", "restrictedScene", cr2w, this);
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
		public CUInt32 Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (CUInt32) CR2WTypeManager.Create("Uint32", "dead", cr2w, this);
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
		public CUInt32 Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (CUInt32) CR2WTypeManager.Create("Uint32", "takedown", cr2w, this);
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
		public CUInt32 DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (CUInt32) CR2WTypeManager.Create("Uint32", "deviceTakeover", cr2w, this);
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
		public CUInt32 BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (CUInt32) CR2WTypeManager.Create("Uint32", "braindanceFPP", cr2w, this);
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
		public CUInt32 BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (CUInt32) CR2WTypeManager.Create("Uint32", "braindanceActive", cr2w, this);
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
		public CUInt32 VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (CUInt32) CR2WTypeManager.Create("Uint32", "veryHardLanding", cr2w, this);
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
		public CUInt32 NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (CUInt32) CR2WTypeManager.Create("Uint32", "noScanningRestriction", cr2w, this);
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

		public PlayerVisionModeControllerBBListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
