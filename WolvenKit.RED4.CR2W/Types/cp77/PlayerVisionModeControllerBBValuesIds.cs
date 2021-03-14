using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBValuesIds : CVariable
	{
		private gamebbScriptID_Int32 _kerenzikov;
		private gamebbScriptID_Int32 _restrictedScene;
		private gamebbScriptID_Int32 _dead;
		private gamebbScriptID_Int32 _takedown;
		private gamebbScriptID_EntityID _deviceTakeover;
		private gamebbScriptID_Bool _braindanceFPP;
		private gamebbScriptID_Bool _braindanceActive;
		private gamebbScriptID_Int32 _veryHardLanding;
		private gamebbScriptID_Variant _noScanningRestriction;

		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public gamebbScriptID_Int32 Kerenzikov
		{
			get
			{
				if (_kerenzikov == null)
				{
					_kerenzikov = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "kerenzikov", cr2w, this);
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
		public gamebbScriptID_Int32 RestrictedScene
		{
			get
			{
				if (_restrictedScene == null)
				{
					_restrictedScene = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "restrictedScene", cr2w, this);
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
		public gamebbScriptID_Int32 Dead
		{
			get
			{
				if (_dead == null)
				{
					_dead = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "dead", cr2w, this);
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
		public gamebbScriptID_Int32 Takedown
		{
			get
			{
				if (_takedown == null)
				{
					_takedown = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "takedown", cr2w, this);
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
		public gamebbScriptID_EntityID DeviceTakeover
		{
			get
			{
				if (_deviceTakeover == null)
				{
					_deviceTakeover = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "deviceTakeover", cr2w, this);
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
		public gamebbScriptID_Bool BraindanceFPP
		{
			get
			{
				if (_braindanceFPP == null)
				{
					_braindanceFPP = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "braindanceFPP", cr2w, this);
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
		public gamebbScriptID_Bool BraindanceActive
		{
			get
			{
				if (_braindanceActive == null)
				{
					_braindanceActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "braindanceActive", cr2w, this);
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
		public gamebbScriptID_Int32 VeryHardLanding
		{
			get
			{
				if (_veryHardLanding == null)
				{
					_veryHardLanding = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "veryHardLanding", cr2w, this);
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
		public gamebbScriptID_Variant NoScanningRestriction
		{
			get
			{
				if (_noScanningRestriction == null)
				{
					_noScanningRestriction = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "noScanningRestriction", cr2w, this);
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

		public PlayerVisionModeControllerBBValuesIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
