using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubMenuPanelLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _levelValue;
		private inkTextWidgetReference _streetCredLabel;
		private inkTextWidgetReference _currencyValue;
		private inkTextWidgetReference _weightValue;
		private inkTextWidgetReference _subMenuLabel;
		private inkWidgetReference _centralLine;
		private inkWidgetReference _levelBarProgress;
		private inkWidgetReference _levelBarSpacer;
		private inkWidgetReference _streetCredBarProgress;
		private inkWidgetReference _streetCredBarSpacer;
		private inkWidgetReference _menuselectorWidget;
		private inkWidgetReference _subMenuselectorWidget;
		private inkWidgetReference _topPanel;
		private inkWidgetReference _leftHolder;
		private inkWidgetReference _rightHolder;
		private inkCompoundWidgetReference _lineBarsContainer;
		private inkCompoundWidgetReference _lineWidget;
		private CArray<MenuData> _menusList;
		private wCHandle<hubSelectorSingleCarouselController> _menuSelectorCtrl;
		private CBool _subMenuActive;
		private wCHandle<inkWidget> _previousLineBar;
		private CBool _isSetActive;
		private CBool _selectorMode;
		private CHandle<MenuDataBuilder> _menusData;
		private MenuData _curMenuData;
		private MenuData _curSubMenuData;

		[Ordinal(1)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get
			{
				if (_levelValue == null)
				{
					_levelValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelValue", cr2w, this);
				}
				return _levelValue;
			}
			set
			{
				if (_levelValue == value)
				{
					return;
				}
				_levelValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get
			{
				if (_streetCredLabel == null)
				{
					_streetCredLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "streetCredLabel", cr2w, this);
				}
				return _streetCredLabel;
			}
			set
			{
				if (_streetCredLabel == value)
				{
					return;
				}
				_streetCredLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currencyValue")] 
		public inkTextWidgetReference CurrencyValue
		{
			get
			{
				if (_currencyValue == null)
				{
					_currencyValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currencyValue", cr2w, this);
				}
				return _currencyValue;
			}
			set
			{
				if (_currencyValue == value)
				{
					return;
				}
				_currencyValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weightValue")] 
		public inkTextWidgetReference WeightValue
		{
			get
			{
				if (_weightValue == null)
				{
					_weightValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weightValue", cr2w, this);
				}
				return _weightValue;
			}
			set
			{
				if (_weightValue == value)
				{
					return;
				}
				_weightValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("subMenuLabel")] 
		public inkTextWidgetReference SubMenuLabel
		{
			get
			{
				if (_subMenuLabel == null)
				{
					_subMenuLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subMenuLabel", cr2w, this);
				}
				return _subMenuLabel;
			}
			set
			{
				if (_subMenuLabel == value)
				{
					return;
				}
				_subMenuLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("centralLine")] 
		public inkWidgetReference CentralLine
		{
			get
			{
				if (_centralLine == null)
				{
					_centralLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "centralLine", cr2w, this);
				}
				return _centralLine;
			}
			set
			{
				if (_centralLine == value)
				{
					return;
				}
				_centralLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get
			{
				if (_levelBarProgress == null)
				{
					_levelBarProgress = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBarProgress", cr2w, this);
				}
				return _levelBarProgress;
			}
			set
			{
				if (_levelBarProgress == value)
				{
					return;
				}
				_levelBarProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get
			{
				if (_levelBarSpacer == null)
				{
					_levelBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBarSpacer", cr2w, this);
				}
				return _levelBarSpacer;
			}
			set
			{
				if (_levelBarSpacer == value)
				{
					return;
				}
				_levelBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get
			{
				if (_streetCredBarProgress == null)
				{
					_streetCredBarProgress = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredBarProgress", cr2w, this);
				}
				return _streetCredBarProgress;
			}
			set
			{
				if (_streetCredBarProgress == value)
				{
					return;
				}
				_streetCredBarProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get
			{
				if (_streetCredBarSpacer == null)
				{
					_streetCredBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredBarSpacer", cr2w, this);
				}
				return _streetCredBarSpacer;
			}
			set
			{
				if (_streetCredBarSpacer == value)
				{
					return;
				}
				_streetCredBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("menuselectorWidget")] 
		public inkWidgetReference MenuselectorWidget
		{
			get
			{
				if (_menuselectorWidget == null)
				{
					_menuselectorWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuselectorWidget", cr2w, this);
				}
				return _menuselectorWidget;
			}
			set
			{
				if (_menuselectorWidget == value)
				{
					return;
				}
				_menuselectorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("subMenuselectorWidget")] 
		public inkWidgetReference SubMenuselectorWidget
		{
			get
			{
				if (_subMenuselectorWidget == null)
				{
					_subMenuselectorWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "subMenuselectorWidget", cr2w, this);
				}
				return _subMenuselectorWidget;
			}
			set
			{
				if (_subMenuselectorWidget == value)
				{
					return;
				}
				_subMenuselectorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("topPanel")] 
		public inkWidgetReference TopPanel
		{
			get
			{
				if (_topPanel == null)
				{
					_topPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "topPanel", cr2w, this);
				}
				return _topPanel;
			}
			set
			{
				if (_topPanel == value)
				{
					return;
				}
				_topPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("leftHolder")] 
		public inkWidgetReference LeftHolder
		{
			get
			{
				if (_leftHolder == null)
				{
					_leftHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftHolder", cr2w, this);
				}
				return _leftHolder;
			}
			set
			{
				if (_leftHolder == value)
				{
					return;
				}
				_leftHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rightHolder")] 
		public inkWidgetReference RightHolder
		{
			get
			{
				if (_rightHolder == null)
				{
					_rightHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightHolder", cr2w, this);
				}
				return _rightHolder;
			}
			set
			{
				if (_rightHolder == value)
				{
					return;
				}
				_rightHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lineBarsContainer")] 
		public inkCompoundWidgetReference LineBarsContainer
		{
			get
			{
				if (_lineBarsContainer == null)
				{
					_lineBarsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "lineBarsContainer", cr2w, this);
				}
				return _lineBarsContainer;
			}
			set
			{
				if (_lineBarsContainer == value)
				{
					return;
				}
				_lineBarsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lineWidget")] 
		public inkCompoundWidgetReference LineWidget
		{
			get
			{
				if (_lineWidget == null)
				{
					_lineWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "lineWidget", cr2w, this);
				}
				return _lineWidget;
			}
			set
			{
				if (_lineWidget == value)
				{
					return;
				}
				_lineWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("menusList")] 
		public CArray<MenuData> MenusList
		{
			get
			{
				if (_menusList == null)
				{
					_menusList = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "menusList", cr2w, this);
				}
				return _menusList;
			}
			set
			{
				if (_menusList == value)
				{
					return;
				}
				_menusList = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("menuSelectorCtrl")] 
		public wCHandle<hubSelectorSingleCarouselController> MenuSelectorCtrl
		{
			get
			{
				if (_menuSelectorCtrl == null)
				{
					_menuSelectorCtrl = (wCHandle<hubSelectorSingleCarouselController>) CR2WTypeManager.Create("whandle:hubSelectorSingleCarouselController", "menuSelectorCtrl", cr2w, this);
				}
				return _menuSelectorCtrl;
			}
			set
			{
				if (_menuSelectorCtrl == value)
				{
					return;
				}
				_menuSelectorCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("subMenuActive")] 
		public CBool SubMenuActive
		{
			get
			{
				if (_subMenuActive == null)
				{
					_subMenuActive = (CBool) CR2WTypeManager.Create("Bool", "subMenuActive", cr2w, this);
				}
				return _subMenuActive;
			}
			set
			{
				if (_subMenuActive == value)
				{
					return;
				}
				_subMenuActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("previousLineBar")] 
		public wCHandle<inkWidget> PreviousLineBar
		{
			get
			{
				if (_previousLineBar == null)
				{
					_previousLineBar = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "previousLineBar", cr2w, this);
				}
				return _previousLineBar;
			}
			set
			{
				if (_previousLineBar == value)
				{
					return;
				}
				_previousLineBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("IsSetActive")] 
		public CBool IsSetActive
		{
			get
			{
				if (_isSetActive == null)
				{
					_isSetActive = (CBool) CR2WTypeManager.Create("Bool", "IsSetActive", cr2w, this);
				}
				return _isSetActive;
			}
			set
			{
				if (_isSetActive == value)
				{
					return;
				}
				_isSetActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("selectorMode")] 
		public CBool SelectorMode
		{
			get
			{
				if (_selectorMode == null)
				{
					_selectorMode = (CBool) CR2WTypeManager.Create("Bool", "selectorMode", cr2w, this);
				}
				return _selectorMode;
			}
			set
			{
				if (_selectorMode == value)
				{
					return;
				}
				_selectorMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
		[RED("curMenuData")] 
		public MenuData CurMenuData
		{
			get
			{
				if (_curMenuData == null)
				{
					_curMenuData = (MenuData) CR2WTypeManager.Create("MenuData", "curMenuData", cr2w, this);
				}
				return _curMenuData;
			}
			set
			{
				if (_curMenuData == value)
				{
					return;
				}
				_curMenuData = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("curSubMenuData")] 
		public MenuData CurSubMenuData
		{
			get
			{
				if (_curSubMenuData == null)
				{
					_curSubMenuData = (MenuData) CR2WTypeManager.Create("MenuData", "curSubMenuData", cr2w, this);
				}
				return _curSubMenuData;
			}
			set
			{
				if (_curSubMenuData == value)
				{
					return;
				}
				_curSubMenuData = value;
				PropertySet(this);
			}
		}

		public SubMenuPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
