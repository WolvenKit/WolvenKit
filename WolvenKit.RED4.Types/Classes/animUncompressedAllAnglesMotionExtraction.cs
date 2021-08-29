using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animUncompressedAllAnglesMotionExtraction : animIMotionExtraction
	{
		private CFloat _duration;
		private CArray<Transform> _frames;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("frames")] 
		public CArray<Transform> Frames
		{
			get => GetProperty(ref _frames);
			set => SetProperty(ref _frames, value);
		}
	}
}
