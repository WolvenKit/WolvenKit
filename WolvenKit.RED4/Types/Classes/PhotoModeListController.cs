using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("Panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("menuController")] 
		public CWeakHandle<gameuiMenuGameController> MenuController
		{
			get => GetPropertyValue<CWeakHandle<gameuiMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiMenuGameController>>(value);
		}

		[Ordinal(5)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(6)] 
		[RED("listController")] 
		public CWeakHandle<inkListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(7)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("animationTarget")] 
		public CFloat AnimationTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("elementsAnimationTime")] 
		public CFloat ElementsAnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("elementsAnimationDelay")] 
		public CFloat ElementsAnimationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("currentElementAnimation")] 
		public CInt32 CurrentElementAnimation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PhotoModeListController()
		{
			Panel = new inkVerticalPanelWidgetReference();
			SliderWidget = new inkWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
