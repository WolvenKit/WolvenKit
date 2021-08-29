using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlayAnimEvent : inkanimEvent
	{
		private CName _animName;
		private inkanimPlaybackOptions _playbackOptions;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get => GetProperty(ref _playbackOptions);
			set => SetProperty(ref _playbackOptions, value);
		}
	}
}
