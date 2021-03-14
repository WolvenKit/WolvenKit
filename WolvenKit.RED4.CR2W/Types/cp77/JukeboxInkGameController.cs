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
			get
			{
				if (_actionsPanel == null)
				{
					_actionsPanel = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "ActionsPanel", cr2w, this);
				}
				return _actionsPanel;
			}
			set
			{
				if (_actionsPanel == value)
				{
					return;
				}
				_actionsPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("PriceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "PriceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playButton")] 
		public CHandle<PlayPauseActionWidgetController> PlayButton
		{
			get
			{
				if (_playButton == null)
				{
					_playButton = (CHandle<PlayPauseActionWidgetController>) CR2WTypeManager.Create("handle:PlayPauseActionWidgetController", "playButton", cr2w, this);
				}
				return _playButton;
			}
			set
			{
				if (_playButton == value)
				{
					return;
				}
				_playButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("nextButton")] 
		public CHandle<NextPreviousActionWidgetController> NextButton
		{
			get
			{
				if (_nextButton == null)
				{
					_nextButton = (CHandle<NextPreviousActionWidgetController>) CR2WTypeManager.Create("handle:NextPreviousActionWidgetController", "nextButton", cr2w, this);
				}
				return _nextButton;
			}
			set
			{
				if (_nextButton == value)
				{
					return;
				}
				_nextButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("previousButton")] 
		public CHandle<NextPreviousActionWidgetController> PreviousButton
		{
			get
			{
				if (_previousButton == null)
				{
					_previousButton = (CHandle<NextPreviousActionWidgetController>) CR2WTypeManager.Create("handle:NextPreviousActionWidgetController", "previousButton", cr2w, this);
				}
				return _previousButton;
			}
			set
			{
				if (_previousButton == value)
				{
					return;
				}
				_previousButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get
			{
				if (_isPlaying == null)
				{
					_isPlaying = (CBool) CR2WTypeManager.Create("Bool", "isPlaying", cr2w, this);
				}
				return _isPlaying;
			}
			set
			{
				if (_isPlaying == value)
				{
					return;
				}
				_isPlaying = value;
				PropertySet(this);
			}
		}

		public JukeboxInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
