using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FeaturesExpansionPopupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("hoverAnimationName")] 
		public CName HoverAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("hoverArrow")] 
		public inkImageWidgetReference HoverArrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("buyButtonRef")] 
		public inkWidgetReference BuyButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buyButtonText")] 
		public inkTextWidgetReference BuyButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buyButtonInputIcon")] 
		public inkWidgetReference BuyButtonInputIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buyButtonSpinner")] 
		public inkWidgetReference BuyButtonSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("locKey_Buy")] 
		public CName LocKey_Buy
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("locKey_PreOrder")] 
		public CName LocKey_PreOrder
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("slectorContainerRef")] 
		public inkWidgetReference SlectorContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("slectorArrowLeftRef")] 
		public inkWidgetReference SlectorArrowLeftRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("slectorArrowRightRef")] 
		public inkWidgetReference SlectorArrowRightRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("videoCarouselRef")] 
		public inkWidgetReference VideoCarouselRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("videoContainerRef")] 
		public inkWidgetReference VideoContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("videoCarouselData")] 
		public CArray<VideoCarouselData> VideoCarouselData
		{
			get => GetPropertyValue<CArray<VideoCarouselData>>();
			set => SetPropertyValue<CArray<VideoCarouselData>>(value);
		}

		[Ordinal(15)] 
		[RED("videoCarouselController")] 
		public CWeakHandle<VideoCarouselController> VideoCarouselController
		{
			get => GetPropertyValue<CWeakHandle<VideoCarouselController>>();
			set => SetPropertyValue<CWeakHandle<VideoCarouselController>>(value);
		}

		[Ordinal(16)] 
		[RED("buyButtonController")] 
		public CWeakHandle<inkButtonController> BuyButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(17)] 
		[RED("hoverAnimation")] 
		public CHandle<inkanimProxy> HoverAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("hoverAnimationOptions")] 
		public inkanimPlaybackOptions HoverAnimationOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(19)] 
		[RED("isEp1Released")] 
		public CBool IsEp1Released
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FeaturesExpansionPopupController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
