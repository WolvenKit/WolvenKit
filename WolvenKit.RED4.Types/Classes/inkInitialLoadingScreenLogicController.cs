using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInitialLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkWidgetReference _skipButtonPanel;
		private inkCompoundWidgetReference _loadingPartsContainer;
		private CName _afterSkipAnimation;
		private CName _loadingFinishedAudioStopEvent;
		private inkWidgetReference _progressBarRoot;
		private CWeakHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
		[RED("skipButtonPanel")] 
		public inkWidgetReference SkipButtonPanel
		{
			get => GetProperty(ref _skipButtonPanel);
			set => SetProperty(ref _skipButtonPanel, value);
		}

		[Ordinal(2)] 
		[RED("loadingPartsContainer")] 
		public inkCompoundWidgetReference LoadingPartsContainer
		{
			get => GetProperty(ref _loadingPartsContainer);
			set => SetProperty(ref _loadingPartsContainer, value);
		}

		[Ordinal(3)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get => GetProperty(ref _afterSkipAnimation);
			set => SetProperty(ref _afterSkipAnimation, value);
		}

		[Ordinal(4)] 
		[RED("loadingFinishedAudioStopEvent")] 
		public CName LoadingFinishedAudioStopEvent
		{
			get => GetProperty(ref _loadingFinishedAudioStopEvent);
			set => SetProperty(ref _loadingFinishedAudioStopEvent, value);
		}

		[Ordinal(5)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetProperty(ref _progressBarRoot);
			set => SetProperty(ref _progressBarRoot, value);
		}

		[Ordinal(6)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}
	}
}
