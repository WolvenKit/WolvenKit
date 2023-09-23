using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneDialerSelectionController : inkSelectorController
	{
		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("leftArrowController")] 
		public CWeakHandle<inkInputDisplayController> LeftArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(20)] 
		[RED("rightArrowController")] 
		public CWeakHandle<inkInputDisplayController> RightArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(21)] 
		[RED("widgetsControllers")] 
		public CArray<CWeakHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>(value);
		}

		[Ordinal(22)] 
		[RED("lineTranslationAnimProxy")] 
		public CHandle<inkanimProxy> LineTranslationAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("lineSizeAnimProxy")] 
		public CHandle<inkanimProxy> LineSizeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("animationsRetryDiv")] 
		public CFloat AnimationsRetryDiv
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("highlightInitialized")] 
		public CBool HighlightInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PhoneDialerSelectionController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
