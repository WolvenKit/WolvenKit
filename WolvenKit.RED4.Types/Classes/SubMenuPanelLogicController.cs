using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubMenuPanelLogicController : PlayerStatsUIHolder
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
		private CWeakHandle<hubSelectorSingleCarouselController> _menuSelectorCtrl;
		private CBool _subMenuActive;
		private CWeakHandle<inkWidget> _previousLineBar;
		private CBool _isSetActive;
		private CBool _selectorMode;
		private CHandle<MenuDataBuilder> _menusData;
		private MenuData _curMenuData;
		private MenuData _curSubMenuData;
		private CUInt32 _hubMenuInstanceID;

		[Ordinal(1)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetProperty(ref _levelValue);
			set => SetProperty(ref _levelValue, value);
		}

		[Ordinal(2)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetProperty(ref _streetCredLabel);
			set => SetProperty(ref _streetCredLabel, value);
		}

		[Ordinal(3)] 
		[RED("currencyValue")] 
		public inkTextWidgetReference CurrencyValue
		{
			get => GetProperty(ref _currencyValue);
			set => SetProperty(ref _currencyValue, value);
		}

		[Ordinal(4)] 
		[RED("weightValue")] 
		public inkTextWidgetReference WeightValue
		{
			get => GetProperty(ref _weightValue);
			set => SetProperty(ref _weightValue, value);
		}

		[Ordinal(5)] 
		[RED("subMenuLabel")] 
		public inkTextWidgetReference SubMenuLabel
		{
			get => GetProperty(ref _subMenuLabel);
			set => SetProperty(ref _subMenuLabel, value);
		}

		[Ordinal(6)] 
		[RED("centralLine")] 
		public inkWidgetReference CentralLine
		{
			get => GetProperty(ref _centralLine);
			set => SetProperty(ref _centralLine, value);
		}

		[Ordinal(7)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetProperty(ref _levelBarProgress);
			set => SetProperty(ref _levelBarProgress, value);
		}

		[Ordinal(8)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetProperty(ref _levelBarSpacer);
			set => SetProperty(ref _levelBarSpacer, value);
		}

		[Ordinal(9)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetProperty(ref _streetCredBarProgress);
			set => SetProperty(ref _streetCredBarProgress, value);
		}

		[Ordinal(10)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetProperty(ref _streetCredBarSpacer);
			set => SetProperty(ref _streetCredBarSpacer, value);
		}

		[Ordinal(11)] 
		[RED("menuselectorWidget")] 
		public inkWidgetReference MenuselectorWidget
		{
			get => GetProperty(ref _menuselectorWidget);
			set => SetProperty(ref _menuselectorWidget, value);
		}

		[Ordinal(12)] 
		[RED("subMenuselectorWidget")] 
		public inkWidgetReference SubMenuselectorWidget
		{
			get => GetProperty(ref _subMenuselectorWidget);
			set => SetProperty(ref _subMenuselectorWidget, value);
		}

		[Ordinal(13)] 
		[RED("topPanel")] 
		public inkWidgetReference TopPanel
		{
			get => GetProperty(ref _topPanel);
			set => SetProperty(ref _topPanel, value);
		}

		[Ordinal(14)] 
		[RED("leftHolder")] 
		public inkWidgetReference LeftHolder
		{
			get => GetProperty(ref _leftHolder);
			set => SetProperty(ref _leftHolder, value);
		}

		[Ordinal(15)] 
		[RED("rightHolder")] 
		public inkWidgetReference RightHolder
		{
			get => GetProperty(ref _rightHolder);
			set => SetProperty(ref _rightHolder, value);
		}

		[Ordinal(16)] 
		[RED("lineBarsContainer")] 
		public inkCompoundWidgetReference LineBarsContainer
		{
			get => GetProperty(ref _lineBarsContainer);
			set => SetProperty(ref _lineBarsContainer, value);
		}

		[Ordinal(17)] 
		[RED("lineWidget")] 
		public inkCompoundWidgetReference LineWidget
		{
			get => GetProperty(ref _lineWidget);
			set => SetProperty(ref _lineWidget, value);
		}

		[Ordinal(18)] 
		[RED("menusList")] 
		public CArray<MenuData> MenusList
		{
			get => GetProperty(ref _menusList);
			set => SetProperty(ref _menusList, value);
		}

		[Ordinal(19)] 
		[RED("menuSelectorCtrl")] 
		public CWeakHandle<hubSelectorSingleCarouselController> MenuSelectorCtrl
		{
			get => GetProperty(ref _menuSelectorCtrl);
			set => SetProperty(ref _menuSelectorCtrl, value);
		}

		[Ordinal(20)] 
		[RED("subMenuActive")] 
		public CBool SubMenuActive
		{
			get => GetProperty(ref _subMenuActive);
			set => SetProperty(ref _subMenuActive, value);
		}

		[Ordinal(21)] 
		[RED("previousLineBar")] 
		public CWeakHandle<inkWidget> PreviousLineBar
		{
			get => GetProperty(ref _previousLineBar);
			set => SetProperty(ref _previousLineBar, value);
		}

		[Ordinal(22)] 
		[RED("IsSetActive")] 
		public CBool IsSetActive
		{
			get => GetProperty(ref _isSetActive);
			set => SetProperty(ref _isSetActive, value);
		}

		[Ordinal(23)] 
		[RED("selectorMode")] 
		public CBool SelectorMode
		{
			get => GetProperty(ref _selectorMode);
			set => SetProperty(ref _selectorMode, value);
		}

		[Ordinal(24)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get => GetProperty(ref _menusData);
			set => SetProperty(ref _menusData, value);
		}

		[Ordinal(25)] 
		[RED("curMenuData")] 
		public MenuData CurMenuData
		{
			get => GetProperty(ref _curMenuData);
			set => SetProperty(ref _curMenuData, value);
		}

		[Ordinal(26)] 
		[RED("curSubMenuData")] 
		public MenuData CurSubMenuData
		{
			get => GetProperty(ref _curSubMenuData);
			set => SetProperty(ref _curSubMenuData, value);
		}

		[Ordinal(27)] 
		[RED("hubMenuInstanceID")] 
		public CUInt32 HubMenuInstanceID
		{
			get => GetProperty(ref _hubMenuInstanceID);
			set => SetProperty(ref _hubMenuInstanceID, value);
		}
	}
}
