using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CreditsGameController : gameuiCreditsController
	{
		[Ordinal(26)] 
		[RED("videoContainer")] 
		public inkCompoundWidgetReference VideoContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("sceneTexture")] 
		public inkImageWidgetReference SceneTexture
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("binkVideo")] 
		public inkVideoWidgetReference BinkVideo
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("binkVideos")] 
		public CArray<gameuiBinkResource> BinkVideos
		{
			get => GetPropertyValue<CArray<gameuiBinkResource>>();
			set => SetPropertyValue<CArray<gameuiBinkResource>>(value);
		}

		[Ordinal(31)] 
		[RED("currentBinkVideo")] 
		public CInt32 CurrentBinkVideo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("videoSummary")] 
		public inkVideoWidgetSummary VideoSummary
		{
			get => GetPropertyValue<inkVideoWidgetSummary>();
			set => SetPropertyValue<inkVideoWidgetSummary>(value);
		}

		[Ordinal(33)] 
		[RED("isDataSet")] 
		public CBool IsDataSet
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
			VideoSummary = new inkVideoWidgetSummary();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
