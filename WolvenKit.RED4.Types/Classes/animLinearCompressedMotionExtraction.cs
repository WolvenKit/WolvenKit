using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLinearCompressedMotionExtraction : animIMotionExtraction
	{
		private CFloat _duration;
		private CArray<Quaternion> _rotFrames;
		private CArray<Vector3> _posFrames;
		private CArray<CFloat> _rotTime;
		private CArray<CFloat> _posTime;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("rotFrames")] 
		public CArray<Quaternion> RotFrames
		{
			get => GetProperty(ref _rotFrames);
			set => SetProperty(ref _rotFrames, value);
		}

		[Ordinal(2)] 
		[RED("posFrames")] 
		public CArray<Vector3> PosFrames
		{
			get => GetProperty(ref _posFrames);
			set => SetProperty(ref _posFrames, value);
		}

		[Ordinal(3)] 
		[RED("rotTime")] 
		public CArray<CFloat> RotTime
		{
			get => GetProperty(ref _rotTime);
			set => SetProperty(ref _rotTime, value);
		}

		[Ordinal(4)] 
		[RED("posTime")] 
		public CArray<CFloat> PosTime
		{
			get => GetProperty(ref _posTime);
			set => SetProperty(ref _posTime, value);
		}
	}
}
