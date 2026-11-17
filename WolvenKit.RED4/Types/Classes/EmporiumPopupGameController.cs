using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmporiumPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("descriptionRef")] 
		public inkRichTextBoxWidgetReference DescriptionRef
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("videoWidgetRef")] 
		public inkVideoWidgetReference VideoWidgetRef
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("prevTabButtonRef")] 
		public inkWidgetReference PrevTabButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("nextTabButtonRef")] 
		public inkWidgetReference NextTabButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("tabButtonRef", 4)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(10)] 
		[RED("tabButtonLabelRef", 4)] 
		public CArrayFixedSize<inkTextWidgetReference> TabButtonLabelRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>(value);
		}

		[Ordinal(11)] 
		[RED("tabButtonBkgRef", 4)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonBkgRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("contentData", 4)] 
		public CArrayFixedSize<VideoCarouselData> ContentData
		{
			get => GetPropertyValue<CArrayFixedSize<VideoCarouselData>>();
			set => SetPropertyValue<CArrayFixedSize<VideoCarouselData>>(value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<EmporiumPopupData> Data
		{
			get => GetPropertyValue<CHandle<EmporiumPopupData>>();
			set => SetPropertyValue<CHandle<EmporiumPopupData>>(value);
		}

		[Ordinal(14)] 
		[RED("videoWidget")] 
		public CWeakHandle<inkVideoWidget> VideoWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("prevTabButton")] 
		public CWeakHandle<inkButtonController> PrevTabButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(16)] 
		[RED("nextTabButton")] 
		public CWeakHandle<inkButtonController> NextTabButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(17)] 
		[RED("activeTab")] 
		public CInt32 ActiveTab
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public EmporiumPopupGameController()
		{
			CloseButtonRef = new inkWidgetReference();
			TitleRef = new inkTextWidgetReference();
			DescriptionRef = new inkRichTextBoxWidgetReference();
			VideoWidgetRef = new inkVideoWidgetReference();
			IntroAnimationName = "intro";
			PrevTabButtonRef = new inkWidgetReference();
			NextTabButtonRef = new inkWidgetReference();
			TabButtonRef = new(4);
			TabButtonLabelRef = new(4);
			TabButtonBkgRef = new(4);
			ContentData = new(4);
			ActiveTab = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
