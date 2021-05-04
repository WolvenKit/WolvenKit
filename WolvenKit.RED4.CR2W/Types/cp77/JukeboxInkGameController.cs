using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxInkGameController : DeviceInkGameControllerBase
	{
		private inkHorizontalPanelWidgetReference _actionsPanel;
		private inkTextWidgetReference _priceText;
		private CHandle<PlayPauseActionWidgetController> _playButton;
		private CHandle<NextPreviousActionWidgetController> _nextButton;
		private CHandle<NextPreviousActionWidgetController> _previousButton;
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
		public CHandle<PlayPauseActionWidgetController> PlayButton
		{
			get => GetProperty(ref _playButton);
			set => SetProperty(ref _playButton, value);
		}

		[Ordinal(19)] 
		[RED("nextButton")] 
		public CHandle<NextPreviousActionWidgetController> NextButton
		{
			get => GetProperty(ref _nextButton);
			set => SetProperty(ref _nextButton, value);
		}

		[Ordinal(20)] 
		[RED("previousButton")] 
		public CHandle<NextPreviousActionWidgetController> PreviousButton
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

		public JukeboxInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
