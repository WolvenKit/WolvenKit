using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		private CFloat _time;
		private CBool _skipToEnd;
		private CBool _forcePlay;

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}

		[Ordinal(3)] 
		[RED("forcePlay")] 
		public CBool ForcePlay
		{
			get => GetProperty(ref _forcePlay);
			set => SetProperty(ref _forcePlay, value);
		}
	}
}
