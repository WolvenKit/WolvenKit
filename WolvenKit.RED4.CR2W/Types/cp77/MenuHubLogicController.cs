using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuHubLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _menuObject;
		private inkWidgetReference _btnCrafting;
		private inkWidgetReference _btnPerks;
		private inkWidgetReference _btnStats;
		private inkWidgetReference _btnInventory;
		private inkWidgetReference _btnBackpack;
		private inkWidgetReference _btnCyberware;
		private inkWidgetReference _btnMap;
		private inkWidgetReference _btnJournal;
		private inkWidgetReference _btnPhone;
		private inkWidgetReference _btnTarot;
		private inkWidgetReference _btnShard;
		private inkWidgetReference _btnCodex;
		private inkWidgetReference _panelInventory;
		private inkWidgetReference _panelJournal;
		private inkWidgetReference _panelCharacter;
		private CHandle<MenuDataBuilder> _menusData;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkWidgetReference _tooltipsManagerRef;

		[Ordinal(1)] 
		[RED("menuObject")] 
		public inkWidgetReference MenuObject
		{
			get
			{
				if (_menuObject == null)
				{
					_menuObject = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuObject", cr2w, this);
				}
				return _menuObject;
			}
			set
			{
				if (_menuObject == value)
				{
					return;
				}
				_menuObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("btnCrafting")] 
		public inkWidgetReference BtnCrafting
		{
			get
			{
				if (_btnCrafting == null)
				{
					_btnCrafting = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnCrafting", cr2w, this);
				}
				return _btnCrafting;
			}
			set
			{
				if (_btnCrafting == value)
				{
					return;
				}
				_btnCrafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("btnPerks")] 
		public inkWidgetReference BtnPerks
		{
			get
			{
				if (_btnPerks == null)
				{
					_btnPerks = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnPerks", cr2w, this);
				}
				return _btnPerks;
			}
			set
			{
				if (_btnPerks == value)
				{
					return;
				}
				_btnPerks = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get
			{
				if (_btnStats == null)
				{
					_btnStats = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnStats", cr2w, this);
				}
				return _btnStats;
			}
			set
			{
				if (_btnStats == value)
				{
					return;
				}
				_btnStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get
			{
				if (_btnInventory == null)
				{
					_btnInventory = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnInventory", cr2w, this);
				}
				return _btnInventory;
			}
			set
			{
				if (_btnInventory == value)
				{
					return;
				}
				_btnInventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get
			{
				if (_btnBackpack == null)
				{
					_btnBackpack = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnBackpack", cr2w, this);
				}
				return _btnBackpack;
			}
			set
			{
				if (_btnBackpack == value)
				{
					return;
				}
				_btnBackpack = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get
			{
				if (_btnCyberware == null)
				{
					_btnCyberware = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnCyberware", cr2w, this);
				}
				return _btnCyberware;
			}
			set
			{
				if (_btnCyberware == value)
				{
					return;
				}
				_btnCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("btnMap")] 
		public inkWidgetReference BtnMap
		{
			get
			{
				if (_btnMap == null)
				{
					_btnMap = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnMap", cr2w, this);
				}
				return _btnMap;
			}
			set
			{
				if (_btnMap == value)
				{
					return;
				}
				_btnMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("btnJournal")] 
		public inkWidgetReference BtnJournal
		{
			get
			{
				if (_btnJournal == null)
				{
					_btnJournal = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnJournal", cr2w, this);
				}
				return _btnJournal;
			}
			set
			{
				if (_btnJournal == value)
				{
					return;
				}
				_btnJournal = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("btnPhone")] 
		public inkWidgetReference BtnPhone
		{
			get
			{
				if (_btnPhone == null)
				{
					_btnPhone = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnPhone", cr2w, this);
				}
				return _btnPhone;
			}
			set
			{
				if (_btnPhone == value)
				{
					return;
				}
				_btnPhone = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("btnTarot")] 
		public inkWidgetReference BtnTarot
		{
			get
			{
				if (_btnTarot == null)
				{
					_btnTarot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnTarot", cr2w, this);
				}
				return _btnTarot;
			}
			set
			{
				if (_btnTarot == value)
				{
					return;
				}
				_btnTarot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("btnShard")] 
		public inkWidgetReference BtnShard
		{
			get
			{
				if (_btnShard == null)
				{
					_btnShard = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnShard", cr2w, this);
				}
				return _btnShard;
			}
			set
			{
				if (_btnShard == value)
				{
					return;
				}
				_btnShard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("btnCodex")] 
		public inkWidgetReference BtnCodex
		{
			get
			{
				if (_btnCodex == null)
				{
					_btnCodex = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnCodex", cr2w, this);
				}
				return _btnCodex;
			}
			set
			{
				if (_btnCodex == value)
				{
					return;
				}
				_btnCodex = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("panelInventory")] 
		public inkWidgetReference PanelInventory
		{
			get
			{
				if (_panelInventory == null)
				{
					_panelInventory = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "panelInventory", cr2w, this);
				}
				return _panelInventory;
			}
			set
			{
				if (_panelInventory == value)
				{
					return;
				}
				_panelInventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("panelJournal")] 
		public inkWidgetReference PanelJournal
		{
			get
			{
				if (_panelJournal == null)
				{
					_panelJournal = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "panelJournal", cr2w, this);
				}
				return _panelJournal;
			}
			set
			{
				if (_panelJournal == value)
				{
					return;
				}
				_panelJournal = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("panelCharacter")] 
		public inkWidgetReference PanelCharacter
		{
			get
			{
				if (_panelCharacter == null)
				{
					_panelCharacter = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "panelCharacter", cr2w, this);
				}
				return _panelCharacter;
			}
			set
			{
				if (_panelCharacter == value)
				{
					return;
				}
				_panelCharacter = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get
			{
				if (_menusData == null)
				{
					_menusData = (CHandle<MenuDataBuilder>) CR2WTypeManager.Create("handle:MenuDataBuilder", "menusData", cr2w, this);
				}
				return _menusData;
			}
			set
			{
				if (_menusData == value)
				{
					return;
				}
				_menusData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		public MenuHubLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
