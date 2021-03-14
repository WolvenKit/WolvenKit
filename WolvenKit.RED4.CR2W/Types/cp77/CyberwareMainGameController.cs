using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareMainGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _mainViewRoot;
		private inkCompoundWidgetReference _cyberwareColumnLeft;
		private inkCompoundWidgetReference _cyberwareColumnRight;
		private inkCompoundWidgetReference _personalStatsList;
		private inkCompoundWidgetReference _attributesList;
		private inkCompoundWidgetReference _resistancesList;
		private inkWidgetReference _tooltipsManagerRef;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CName _resistanceView;
		private CName _statView;
		private inkMargin _toolTipOffset;
		private CArray<gameStatViewData> _rawStatsData;

		[Ordinal(2)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get
			{
				if (_mainViewRoot == null)
				{
					_mainViewRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MainViewRoot", cr2w, this);
				}
				return _mainViewRoot;
			}
			set
			{
				if (_mainViewRoot == value)
				{
					return;
				}
				_mainViewRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("CyberwareColumnLeft")] 
		public inkCompoundWidgetReference CyberwareColumnLeft
		{
			get
			{
				if (_cyberwareColumnLeft == null)
				{
					_cyberwareColumnLeft = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CyberwareColumnLeft", cr2w, this);
				}
				return _cyberwareColumnLeft;
			}
			set
			{
				if (_cyberwareColumnLeft == value)
				{
					return;
				}
				_cyberwareColumnLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CyberwareColumnRight")] 
		public inkCompoundWidgetReference CyberwareColumnRight
		{
			get
			{
				if (_cyberwareColumnRight == null)
				{
					_cyberwareColumnRight = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CyberwareColumnRight", cr2w, this);
				}
				return _cyberwareColumnRight;
			}
			set
			{
				if (_cyberwareColumnRight == value)
				{
					return;
				}
				_cyberwareColumnRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("personalStatsList")] 
		public inkCompoundWidgetReference PersonalStatsList
		{
			get
			{
				if (_personalStatsList == null)
				{
					_personalStatsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "personalStatsList", cr2w, this);
				}
				return _personalStatsList;
			}
			set
			{
				if (_personalStatsList == value)
				{
					return;
				}
				_personalStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("attributesList")] 
		public inkCompoundWidgetReference AttributesList
		{
			get
			{
				if (_attributesList == null)
				{
					_attributesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "attributesList", cr2w, this);
				}
				return _attributesList;
			}
			set
			{
				if (_attributesList == value)
				{
					return;
				}
				_attributesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("resistancesList")] 
		public inkCompoundWidgetReference ResistancesList
		{
			get
			{
				if (_resistancesList == null)
				{
					_resistancesList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "resistancesList", cr2w, this);
				}
				return _resistancesList;
			}
			set
			{
				if (_resistancesList == value)
				{
					return;
				}
				_resistancesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
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

		[Ordinal(9)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
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

		[Ordinal(10)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("resistanceView")] 
		public CName ResistanceView
		{
			get
			{
				if (_resistanceView == null)
				{
					_resistanceView = (CName) CR2WTypeManager.Create("CName", "resistanceView", cr2w, this);
				}
				return _resistanceView;
			}
			set
			{
				if (_resistanceView == value)
				{
					return;
				}
				_resistanceView = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("statView")] 
		public CName StatView
		{
			get
			{
				if (_statView == null)
				{
					_statView = (CName) CR2WTypeManager.Create("CName", "statView", cr2w, this);
				}
				return _statView;
			}
			set
			{
				if (_statView == value)
				{
					return;
				}
				_statView = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get
			{
				if (_toolTipOffset == null)
				{
					_toolTipOffset = (inkMargin) CR2WTypeManager.Create("inkMargin", "toolTipOffset", cr2w, this);
				}
				return _toolTipOffset;
			}
			set
			{
				if (_toolTipOffset == value)
				{
					return;
				}
				_toolTipOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rawStatsData")] 
		public CArray<gameStatViewData> RawStatsData
		{
			get
			{
				if (_rawStatsData == null)
				{
					_rawStatsData = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "rawStatsData", cr2w, this);
				}
				return _rawStatsData;
			}
			set
			{
				if (_rawStatsData == value)
				{
					return;
				}
				_rawStatsData = value;
				PropertySet(this);
			}
		}

		public CyberwareMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
