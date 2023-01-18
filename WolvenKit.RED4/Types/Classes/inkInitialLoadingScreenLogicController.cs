using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkInitialLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] 
		[RED("skipButtonPanel")] 
		public inkWidgetReference SkipButtonPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("loadingPartsContainer")] 
		public inkCompoundWidgetReference LoadingPartsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("loadingFinishedAudioStopEvent")] 
		public CName LoadingFinishedAudioStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>();
			set => SetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>(value);
		}

		public inkInitialLoadingScreenLogicController()
		{
			SkipButtonPanel = new();
			LoadingPartsContainer = new();
			ProgressBarRoot = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
