using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STransformAnimationSkipEventData : RedBaseClass
	{
		private CFloat _time;
		private CBool _skipToEnd;

		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}
	}
}
