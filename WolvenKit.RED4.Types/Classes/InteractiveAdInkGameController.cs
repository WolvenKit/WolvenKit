using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveAdInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("ProcessingVideo")] 
		public inkVideoWidgetReference ProcessingVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("PersonalAd")] 
		public inkVideoWidgetReference PersonalAd
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("CommonAd")] 
		public inkVideoWidgetReference CommonAd
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("fadeDuration")] 
		public CFloat FadeDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("animFade")] 
		public CHandle<inkanimDefinition> AnimFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(21)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(22)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("onShowAdListener")] 
		public CHandle<redCallbackObject> OnShowAdListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("onShowVendorListener")] 
		public CHandle<redCallbackObject> OnShowVendorListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public InteractiveAdInkGameController()
		{
			ProcessingVideo = new();
			PersonalAd = new();
			CommonAd = new();
			FadeDuration = 0.500000F;
			AnimOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
