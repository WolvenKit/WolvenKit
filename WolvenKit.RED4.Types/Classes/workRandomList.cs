using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workRandomList : workIContainerEntry
	{
		private CInt8 _minClips;
		private CInt8 _maxClips;
		private CFloat _pauseBetweenLength;
		private CFloat _pauseLengthDeviation;
		private CArray<CFloat> _weights;
		private CFloat _pauseBlendOutTime;
		private CInt8 _dontRepeatLastAnims;

		[Ordinal(4)] 
		[RED("minClips")] 
		public CInt8 MinClips
		{
			get => GetProperty(ref _minClips);
			set => SetProperty(ref _minClips, value);
		}

		[Ordinal(5)] 
		[RED("maxClips")] 
		public CInt8 MaxClips
		{
			get => GetProperty(ref _maxClips);
			set => SetProperty(ref _maxClips, value);
		}

		[Ordinal(6)] 
		[RED("pauseBetweenLength")] 
		public CFloat PauseBetweenLength
		{
			get => GetProperty(ref _pauseBetweenLength);
			set => SetProperty(ref _pauseBetweenLength, value);
		}

		[Ordinal(7)] 
		[RED("pauseLengthDeviation")] 
		public CFloat PauseLengthDeviation
		{
			get => GetProperty(ref _pauseLengthDeviation);
			set => SetProperty(ref _pauseLengthDeviation, value);
		}

		[Ordinal(8)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}

		[Ordinal(9)] 
		[RED("pauseBlendOutTime")] 
		public CFloat PauseBlendOutTime
		{
			get => GetProperty(ref _pauseBlendOutTime);
			set => SetProperty(ref _pauseBlendOutTime, value);
		}

		[Ordinal(10)] 
		[RED("dontRepeatLastAnims")] 
		public CInt8 DontRepeatLastAnims
		{
			get => GetProperty(ref _dontRepeatLastAnims);
			set => SetProperty(ref _dontRepeatLastAnims, value);
		}

		public workRandomList()
		{
			_minClips = 3;
			_maxClips = 5;
			_pauseBetweenLength = 4.000000F;
			_pauseLengthDeviation = 1.000000F;
			_pauseBlendOutTime = 0.500000F;
			_dontRepeatLastAnims = 1;
		}
	}
}
