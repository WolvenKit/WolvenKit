using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		private inkWidgetReference _playContainer;
		private CBool _isPlaying;

		[Ordinal(33)] 
		[RED("playContainer")] 
		public inkWidgetReference PlayContainer
		{
			get => GetProperty(ref _playContainer);
			set => SetProperty(ref _playContainer, value);
		}

		[Ordinal(34)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}

		public PlayPauseActionWidgetController()
		{
			_isPlaying = true;
		}
	}
}
