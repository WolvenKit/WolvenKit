using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseLimitWeights : RedBaseClass
	{
		private CFloat _min;
		private CFloat _mid;
		private CFloat _max;
		private CInt16 _poseTrackIndex;
		private CUInt8 _type;
		private CBool _isCachable;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("mid")] 
		public CFloat Mid
		{
			get => GetProperty(ref _mid);
			set => SetProperty(ref _mid, value);
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(3)] 
		[RED("poseTrackIndex")] 
		public CInt16 PoseTrackIndex
		{
			get => GetProperty(ref _poseTrackIndex);
			set => SetProperty(ref _poseTrackIndex, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get => GetProperty(ref _isCachable);
			set => SetProperty(ref _isCachable, value);
		}

		public animPoseLimitWeights()
		{
			_min = 1.000000F;
			_mid = 1.000000F;
			_max = 1.000000F;
			_poseTrackIndex = -1;
		}
	}
}
