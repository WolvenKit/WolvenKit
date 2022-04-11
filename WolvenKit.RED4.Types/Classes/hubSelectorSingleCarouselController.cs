using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hubSelectorSingleCarouselController : inkSelectorController
	{
		[Ordinal(15)] 
		[RED("NUMBER_OF_WIDGETS")] 
		public CInt32 NUMBER_OF_WIDGETS
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("WIDGETS_PADDING")] 
		public CFloat WIDGETS_PADDING
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("SMALL_WIDGET_SCALE")] 
		public CFloat SMALL_WIDGET_SCALE
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("SMALL_WIDGET_OPACITY")] 
		public CFloat SMALL_WIDGET_OPACITY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("ANIMATION_TIME")] 
		public CFloat ANIMATION_TIME
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("DEFAULT_WIDGET_COLOR")] 
		public HDRColor DEFAULT_WIDGET_COLOR
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(21)] 
		[RED("SELECTED_WIDGET_COLOR")] 
		public HDRColor SELECTED_WIDGET_COLOR
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(22)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("defaultColorDummy")] 
		public inkWidgetReference DefaultColorDummy
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("activeColorDummy")] 
		public inkWidgetReference ActiveColorDummy
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("leftArrowController")] 
		public CWeakHandle<inkInputDisplayController> LeftArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(28)] 
		[RED("rightArrowController")] 
		public CWeakHandle<inkInputDisplayController> RightArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(29)] 
		[RED("elements")] 
		public CArray<MenuData> Elements
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(30)] 
		[RED("centerElementIndex")] 
		public CInt32 CenterElementIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("widgetsControllers")] 
		public CArray<CWeakHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>(value);
		}

		[Ordinal(32)] 
		[RED("waitForSizes")] 
		public CBool WaitForSizes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("translationOnce")] 
		public CBool TranslationOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("activeAnimations")] 
		public CArray<CHandle<inkanimProxy>> ActiveAnimations
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		public hubSelectorSingleCarouselController()
		{
			NUMBER_OF_WIDGETS = 7;
			WIDGETS_PADDING = 10.000000F;
			SMALL_WIDGET_SCALE = 0.800000F;
			SMALL_WIDGET_OPACITY = 1.000000F;
			ANIMATION_TIME = 0.200000F;
			DEFAULT_WIDGET_COLOR = new();
			SELECTED_WIDGET_COLOR = new();
			LeftArrowWidget = new();
			RightArrowWidget = new();
			Container = new();
			DefaultColorDummy = new();
			ActiveColorDummy = new();
			Elements = new();
			WidgetsControllers = new();
			ActiveAnimations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
