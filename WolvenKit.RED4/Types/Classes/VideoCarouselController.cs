using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VideoCarouselController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("videoTitleRef")] 
		public inkTextWidgetReference VideoTitleRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("videoDescriptionRef")] 
		public inkTextWidgetReference VideoDescriptionRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("videoWidgetRef")] 
		public inkVideoWidgetReference VideoWidgetRef
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("switchLeftArrow")] 
		public inkWidgetReference SwitchLeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("switchRightArrow")] 
		public inkWidgetReference SwitchRightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("switchDotIndicators")] 
		public CArray<inkWidgetReference> SwitchDotIndicators
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("videoWidget")] 
		public CWeakHandle<inkVideoWidget> VideoWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("videoSwitchLeftArrow")] 
		public CWeakHandle<inkButtonController> VideoSwitchLeftArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(9)] 
		[RED("videoSwitchRightArrow")] 
		public CWeakHandle<inkButtonController> VideoSwitchRightArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(10)] 
		[RED("videos")] 
		public CArray<VideoCarouselData> Videos
		{
			get => GetPropertyValue<CArray<VideoCarouselData>>();
			set => SetPropertyValue<CArray<VideoCarouselData>>(value);
		}

		[Ordinal(11)] 
		[RED("currentVideo")] 
		public CInt32 CurrentVideo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VideoCarouselController()
		{
			VideoTitleRef = new inkTextWidgetReference();
			VideoDescriptionRef = new inkTextWidgetReference();
			VideoWidgetRef = new inkVideoWidgetReference();
			SwitchLeftArrow = new inkWidgetReference();
			SwitchRightArrow = new inkWidgetReference();
			SwitchDotIndicators = new();
			Videos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
