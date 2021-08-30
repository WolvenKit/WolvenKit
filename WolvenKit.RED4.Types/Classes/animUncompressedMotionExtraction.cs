using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animUncompressedMotionExtraction : animIMotionExtraction
	{
		private CArray<Vector4> _frames;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<Vector4> Frames
		{
			get => GetProperty(ref _frames);
			set => SetProperty(ref _frames, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public animUncompressedMotionExtraction()
		{
			_duration = 1.000000F;
		}
	}
}
