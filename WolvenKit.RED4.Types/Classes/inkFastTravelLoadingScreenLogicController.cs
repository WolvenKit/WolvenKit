using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		private inkImageWidgetReference _mainBackgroundImage;
		private inkImageWidgetReference _supportBackgroundImage;
		private CName _introAnimationName;
		private CName _loopAnimationName;
		private CName _tooltipAnimName;
		private CName _breathInAnimName;
		private CName _breathOutAnimName;
		private inkRichTextBoxWidgetReference _tooltipsWidget;
		private inkWidgetReference _progressBarRoot;
		private CWeakHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(1)] 
		[RED("mainBackgroundImage")] 
		public inkImageWidgetReference MainBackgroundImage
		{
			get => GetProperty(ref _mainBackgroundImage);
			set => SetProperty(ref _mainBackgroundImage, value);
		}

		[Ordinal(2)] 
		[RED("supportBackgroundImage")] 
		public inkImageWidgetReference SupportBackgroundImage
		{
			get => GetProperty(ref _supportBackgroundImage);
			set => SetProperty(ref _supportBackgroundImage, value);
		}

		[Ordinal(3)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(4)] 
		[RED("loopAnimationName")] 
		public CName LoopAnimationName
		{
			get => GetProperty(ref _loopAnimationName);
			set => SetProperty(ref _loopAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("tooltipAnimName")] 
		public CName TooltipAnimName
		{
			get => GetProperty(ref _tooltipAnimName);
			set => SetProperty(ref _tooltipAnimName, value);
		}

		[Ordinal(6)] 
		[RED("breathInAnimName")] 
		public CName BreathInAnimName
		{
			get => GetProperty(ref _breathInAnimName);
			set => SetProperty(ref _breathInAnimName, value);
		}

		[Ordinal(7)] 
		[RED("breathOutAnimName")] 
		public CName BreathOutAnimName
		{
			get => GetProperty(ref _breathOutAnimName);
			set => SetProperty(ref _breathOutAnimName, value);
		}

		[Ordinal(8)] 
		[RED("tooltipsWidget")] 
		public inkRichTextBoxWidgetReference TooltipsWidget
		{
			get => GetProperty(ref _tooltipsWidget);
			set => SetProperty(ref _tooltipsWidget, value);
		}

		[Ordinal(9)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetProperty(ref _progressBarRoot);
			set => SetProperty(ref _progressBarRoot, value);
		}

		[Ordinal(10)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}
	}
}
