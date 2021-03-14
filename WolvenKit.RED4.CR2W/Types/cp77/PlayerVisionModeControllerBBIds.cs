using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBIds : CVariable
	{
		private CHandle<gamebbScriptDefinition> _kerenzikov;
		private CHandle<gamebbScriptDefinition> _restrictedScene;
		private CHandle<gamebbScriptDefinition> _dead;
		private CHandle<gamebbScriptDefinition> _takedown;
		private CHandle<gamebbScriptDefinition> _deviceTakeover;
		private CHandle<gamebbScriptDefinition> _braindanceFPP;
		private CHandle<gamebbScriptDefinition> _braindanceActive;
		private CHandle<gamebbScriptDefinition> _veryHardLanding;
		private CHandle<gamebbScriptDefinition> _noScanningRestriction;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CHandle<gamebbScriptDefinition> Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "kerenzikov", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "restrictedScene", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "dead", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "takedown", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "deviceTakeover", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "braindanceFPP", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "braindanceActive", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "veryHardLanding", cr2w, this);
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
		public CHandle<gamebbScriptDefinition> NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "noScanningRestriction", cr2w, this);
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

		public PlayerVisionModeControllerBBIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
