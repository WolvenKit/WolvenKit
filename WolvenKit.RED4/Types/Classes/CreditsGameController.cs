using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CreditsGameController : gameuiCreditsController
	{
		[Ordinal(31)] 
		[RED("videoContainer")] 
		public inkCompoundWidgetReference VideoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("sceneTexture")] 
		public inkImageWidgetReference SceneTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("binkVideo")] 
		public inkVideoWidgetReference BinkVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("binkVideos")] 
		public CArray<gameuiBinkResource> BinkVideos
		{
			get => GetPropertyValue<CArray<gameuiBinkResource>>();
			set => SetPropertyValue<CArray<gameuiBinkResource>>(value);
		}

		[Ordinal(36)] 
		[RED("fastForward")] 
		public inkTextWidgetReference FastForward
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("timerUntilFadeEp1")] 
		public CFloat TimerUntilFadeEp1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("musicVideoEp1")] 
		public inkVideoWidgetReference MusicVideoEp1
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("creditsAnimEp1")] 
		public inkCompoundWidgetReference CreditsAnimEp1
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("currentBinkVideo")] 
		public CInt32 CurrentBinkVideo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("videoSummary")] 
		public inkVideoWidgetSummary VideoSummary
		{
			get => GetPropertyValue<inkVideoWidgetSummary>();
			set => SetPropertyValue<inkVideoWidgetSummary>(value);
		}

		[Ordinal(42)] 
		[RED("isDataSet")] 
		public CBool IsDataSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("accumulatedTime")] 
		public CFloat AccumulatedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("isCounting")] 
		public CBool IsCounting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CreditsGameController()
		{
			VideoContainer = new inkCompoundWidgetReference();
			SceneTexture = new inkImageWidgetReference();
			BackgroundVideo = new inkVideoWidgetReference();
			BinkVideo = new inkVideoWidgetReference();
			BinkVideos = new();
			FastForward = new inkTextWidgetReference();
			MusicVideoEp1 = new inkVideoWidgetReference();
			CreditsAnimEp1 = new inkCompoundWidgetReference();
			VideoSummary = new inkVideoWidgetSummary();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
