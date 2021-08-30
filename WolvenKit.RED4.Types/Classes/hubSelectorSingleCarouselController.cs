using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hubSelectorSingleCarouselController : inkSelectorController
	{
		private CInt32 _nUMBER_OF_WIDGETS;
		private CFloat _wIDGETS_PADDING;
		private CFloat _sMALL_WIDGET_SCALE;
		private CFloat _sMALL_WIDGET_OPACITY;
		private CFloat _aNIMATION_TIME;
		private HDRColor _dEFAULT_WIDGET_COLOR;
		private HDRColor _sELECTED_WIDGET_COLOR;
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkWidgetReference _container;
		private inkWidgetReference _defaultColorDummy;
		private inkWidgetReference _activeColorDummy;
		private CWeakHandle<inkInputDisplayController> _leftArrowController;
		private CWeakHandle<inkInputDisplayController> _rightArrowController;
		private CArray<MenuData> _elements;
		private CInt32 _centerElementIndex;
		private CArray<CWeakHandle<HubMenuLabelContentContainer>> _widgetsControllers;
		private CBool _waitForSizes;
		private CBool _translationOnce;
		private CInt32 _currentIndex;
		private CArray<CHandle<inkanimProxy>> _activeAnimations;

		[Ordinal(15)] 
		[RED("NUMBER_OF_WIDGETS")] 
		public CInt32 NUMBER_OF_WIDGETS
		{
			get => GetProperty(ref _nUMBER_OF_WIDGETS);
			set => SetProperty(ref _nUMBER_OF_WIDGETS, value);
		}

		[Ordinal(16)] 
		[RED("WIDGETS_PADDING")] 
		public CFloat WIDGETS_PADDING
		{
			get => GetProperty(ref _wIDGETS_PADDING);
			set => SetProperty(ref _wIDGETS_PADDING, value);
		}

		[Ordinal(17)] 
		[RED("SMALL_WIDGET_SCALE")] 
		public CFloat SMALL_WIDGET_SCALE
		{
			get => GetProperty(ref _sMALL_WIDGET_SCALE);
			set => SetProperty(ref _sMALL_WIDGET_SCALE, value);
		}

		[Ordinal(18)] 
		[RED("SMALL_WIDGET_OPACITY")] 
		public CFloat SMALL_WIDGET_OPACITY
		{
			get => GetProperty(ref _sMALL_WIDGET_OPACITY);
			set => SetProperty(ref _sMALL_WIDGET_OPACITY, value);
		}

		[Ordinal(19)] 
		[RED("ANIMATION_TIME")] 
		public CFloat ANIMATION_TIME
		{
			get => GetProperty(ref _aNIMATION_TIME);
			set => SetProperty(ref _aNIMATION_TIME, value);
		}

		[Ordinal(20)] 
		[RED("DEFAULT_WIDGET_COLOR")] 
		public HDRColor DEFAULT_WIDGET_COLOR
		{
			get => GetProperty(ref _dEFAULT_WIDGET_COLOR);
			set => SetProperty(ref _dEFAULT_WIDGET_COLOR, value);
		}

		[Ordinal(21)] 
		[RED("SELECTED_WIDGET_COLOR")] 
		public HDRColor SELECTED_WIDGET_COLOR
		{
			get => GetProperty(ref _sELECTED_WIDGET_COLOR);
			set => SetProperty(ref _sELECTED_WIDGET_COLOR, value);
		}

		[Ordinal(22)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetProperty(ref _leftArrowWidget);
			set => SetProperty(ref _leftArrowWidget, value);
		}

		[Ordinal(23)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetProperty(ref _rightArrowWidget);
			set => SetProperty(ref _rightArrowWidget, value);
		}

		[Ordinal(24)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(25)] 
		[RED("defaultColorDummy")] 
		public inkWidgetReference DefaultColorDummy
		{
			get => GetProperty(ref _defaultColorDummy);
			set => SetProperty(ref _defaultColorDummy, value);
		}

		[Ordinal(26)] 
		[RED("activeColorDummy")] 
		public inkWidgetReference ActiveColorDummy
		{
			get => GetProperty(ref _activeColorDummy);
			set => SetProperty(ref _activeColorDummy, value);
		}

		[Ordinal(27)] 
		[RED("leftArrowController")] 
		public CWeakHandle<inkInputDisplayController> LeftArrowController
		{
			get => GetProperty(ref _leftArrowController);
			set => SetProperty(ref _leftArrowController, value);
		}

		[Ordinal(28)] 
		[RED("rightArrowController")] 
		public CWeakHandle<inkInputDisplayController> RightArrowController
		{
			get => GetProperty(ref _rightArrowController);
			set => SetProperty(ref _rightArrowController, value);
		}

		[Ordinal(29)] 
		[RED("elements")] 
		public CArray<MenuData> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}

		[Ordinal(30)] 
		[RED("centerElementIndex")] 
		public CInt32 CenterElementIndex
		{
			get => GetProperty(ref _centerElementIndex);
			set => SetProperty(ref _centerElementIndex, value);
		}

		[Ordinal(31)] 
		[RED("widgetsControllers")] 
		public CArray<CWeakHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetProperty(ref _widgetsControllers);
			set => SetProperty(ref _widgetsControllers, value);
		}

		[Ordinal(32)] 
		[RED("waitForSizes")] 
		public CBool WaitForSizes
		{
			get => GetProperty(ref _waitForSizes);
			set => SetProperty(ref _waitForSizes, value);
		}

		[Ordinal(33)] 
		[RED("translationOnce")] 
		public CBool TranslationOnce
		{
			get => GetProperty(ref _translationOnce);
			set => SetProperty(ref _translationOnce, value);
		}

		[Ordinal(34)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		[Ordinal(35)] 
		[RED("activeAnimations")] 
		public CArray<CHandle<inkanimProxy>> ActiveAnimations
		{
			get => GetProperty(ref _activeAnimations);
			set => SetProperty(ref _activeAnimations, value);
		}

		public hubSelectorSingleCarouselController()
		{
			_nUMBER_OF_WIDGETS = 7;
			_wIDGETS_PADDING = 10.000000F;
			_sMALL_WIDGET_SCALE = 0.800000F;
			_sMALL_WIDGET_OPACITY = 1.000000F;
			_aNIMATION_TIME = 0.200000F;
		}
	}
}
