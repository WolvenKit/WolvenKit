using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JukeboxInkGameController : DeviceInkGameControllerBase
	{
		private inkHorizontalPanelWidgetReference _actionsPanel;
		private inkTextWidgetReference _priceText;
		private CWeakHandle<PlayPauseActionWidgetController> _playButton;
		private CWeakHandle<NextPreviousActionWidgetController> _nextButton;
		private CWeakHandle<NextPreviousActionWidgetController> _previousButton;
		private CBool _isPlaying;

		[Ordinal(16)] 
		[RED("ActionsPanel")] 
		public inkHorizontalPanelWidgetReference ActionsPanel
		{
			get => GetProperty(ref _actionsPanel);
			set => SetProperty(ref _actionsPanel, value);
		}

		[Ordinal(17)] 
		[RED("PriceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(18)] 
		[RED("playButton")] 
		public CWeakHandle<PlayPauseActionWidgetController> PlayButton
		{
			get => GetProperty(ref _playButton);
			set => SetProperty(ref _playButton, value);
		}

		[Ordinal(19)] 
		[RED("nextButton")] 
		public CWeakHandle<NextPreviousActionWidgetController> NextButton
		{
			get => GetProperty(ref _nextButton);
			set => SetProperty(ref _nextButton, value);
		}

		[Ordinal(20)] 
		[RED("previousButton")] 
		public CWeakHandle<NextPreviousActionWidgetController> PreviousButton
		{
			get => GetProperty(ref _previousButton);
			set => SetProperty(ref _previousButton, value);
		}

		[Ordinal(21)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}
	}
}
