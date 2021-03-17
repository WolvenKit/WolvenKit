using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkInitialLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkWidgetReference _skipButtonPanel;
		private inkCompoundWidgetReference _loadingPartsContainer;
		private CName _afterSkipAnimation;
		private CName _loadingFinishedAudioStopEvent;
		private inkWidgetReference _progressBarRoot;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

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
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}

		public inkInitialLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
