using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronModeInfoController : TriggerModeLogicController
	{
		private wCHandle<inkWidget> _ammoBarVisibility;
		private wCHandle<inkWidget> _chargeBarVisibility;
		private wCHandle<inkWidget> _fullAutoModeText;
		private wCHandle<inkWidget> _chargeModeText;
		private wCHandle<inkWidget> _fullAutoModeBG;
		private wCHandle<inkWidget> _chargeModeBG;
		private wCHandle<inkWidget> _bg1;
		private wCHandle<inkWidget> _bg2;
		private wCHandle<inkWidget> _vignette;

		[Ordinal(1)] 
		[RED("ammoBarVisibility")] 
		public wCHandle<inkWidget> AmmoBarVisibility
		{
			get
			{
				if (_ammoBarVisibility == null)
				{
					_ammoBarVisibility = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "ammoBarVisibility", cr2w, this);
				}
				return _ammoBarVisibility;
			}
			set
			{
				if (_ammoBarVisibility == value)
				{
					return;
				}
				_ammoBarVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chargeBarVisibility")] 
		public wCHandle<inkWidget> ChargeBarVisibility
		{
			get
			{
				if (_chargeBarVisibility == null)
				{
					_chargeBarVisibility = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeBarVisibility", cr2w, this);
				}
				return _chargeBarVisibility;
			}
			set
			{
				if (_chargeBarVisibility == value)
				{
					return;
				}
				_chargeBarVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fullAutoModeText")] 
		public wCHandle<inkWidget> FullAutoModeText
		{
			get
			{
				if (_fullAutoModeText == null)
				{
					_fullAutoModeText = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "fullAutoModeText", cr2w, this);
				}
				return _fullAutoModeText;
			}
			set
			{
				if (_fullAutoModeText == value)
				{
					return;
				}
				_fullAutoModeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("chargeModeText")] 
		public wCHandle<inkWidget> ChargeModeText
		{
			get
			{
				if (_chargeModeText == null)
				{
					_chargeModeText = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeModeText", cr2w, this);
				}
				return _chargeModeText;
			}
			set
			{
				if (_chargeModeText == value)
				{
					return;
				}
				_chargeModeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fullAutoModeBG")] 
		public wCHandle<inkWidget> FullAutoModeBG
		{
			get
			{
				if (_fullAutoModeBG == null)
				{
					_fullAutoModeBG = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "fullAutoModeBG", cr2w, this);
				}
				return _fullAutoModeBG;
			}
			set
			{
				if (_fullAutoModeBG == value)
				{
					return;
				}
				_fullAutoModeBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("chargeModeBG")] 
		public wCHandle<inkWidget> ChargeModeBG
		{
			get
			{
				if (_chargeModeBG == null)
				{
					_chargeModeBG = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeModeBG", cr2w, this);
				}
				return _chargeModeBG;
			}
			set
			{
				if (_chargeModeBG == value)
				{
					return;
				}
				_chargeModeBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bg1")] 
		public wCHandle<inkWidget> Bg1
		{
			get
			{
				if (_bg1 == null)
				{
					_bg1 = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "bg1", cr2w, this);
				}
				return _bg1;
			}
			set
			{
				if (_bg1 == value)
				{
					return;
				}
				_bg1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bg2")] 
		public wCHandle<inkWidget> Bg2
		{
			get
			{
				if (_bg2 == null)
				{
					_bg2 = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "bg2", cr2w, this);
				}
				return _bg2;
			}
			set
			{
				if (_bg2 == value)
				{
					return;
				}
				_bg2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vignette")] 
		public wCHandle<inkWidget> Vignette
		{
			get
			{
				if (_vignette == null)
				{
					_vignette = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "vignette", cr2w, this);
				}
				return _vignette;
			}
			set
			{
				if (_vignette == value)
				{
					return;
				}
				_vignette = value;
				PropertySet(this);
			}
		}

		public megatronModeInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
