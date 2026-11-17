using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmporiumPatternTutorialPanelGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("descriptionRef")] 
		public inkRichTextBoxWidgetReference DescriptionRef
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("videoWidgetRef")] 
		public inkVideoWidgetReference VideoWidgetRef
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("tabButtonRef", 7)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("tabButtonLabelRef", 7)] 
		public CArrayFixedSize<inkTextWidgetReference> TabButtonLabelRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>(value);
		}

		[Ordinal(8)] 
		[RED("tabButtonBkgRef", 7)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonBkgRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(9)] 
		[RED("contentData", 7)] 
		public CArrayFixedSize<VideoCarouselData> ContentData
		{
			get => GetPropertyValue<CArrayFixedSize<VideoCarouselData>>();
			set => SetPropertyValue<CArrayFixedSize<VideoCarouselData>>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<EmporiumPopupData> Data
		{
			get => GetPropertyValue<CHandle<EmporiumPopupData>>();
			set => SetPropertyValue<CHandle<EmporiumPopupData>>(value);
		}

		[Ordinal(11)] 
		[RED("videoWidget")] 
		public CWeakHandle<inkVideoWidget> VideoWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("activeTab")] 
		public CInt32 ActiveTab
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public EmporiumPatternTutorialPanelGameController()
		{
			CloseButtonRef = new inkWidgetReference();
			DescriptionRef = new inkRichTextBoxWidgetReference();
			VideoWidgetRef = new inkVideoWidgetReference();
			IntroAnimationName = "intro";
			TabButtonRef = new(7);
			TabButtonLabelRef = new(7);
			TabButtonBkgRef = new(7);
			ContentData = new(7);
			ActiveTab = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
