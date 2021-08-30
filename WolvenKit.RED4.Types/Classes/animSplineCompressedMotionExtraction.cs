using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSplineCompressedMotionExtraction : animIMotionExtraction
	{
		private CFloat _duration;
		private CArray<CUInt8> _posKeysData;
		private CArray<CUInt8> _rotKeysData;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("posKeysData")] 
		public CArray<CUInt8> PosKeysData
		{
			get => GetProperty(ref _posKeysData);
			set => SetProperty(ref _posKeysData, value);
		}

		[Ordinal(2)] 
		[RED("rotKeysData")] 
		public CArray<CUInt8> RotKeysData
		{
			get => GetProperty(ref _rotKeysData);
			set => SetProperty(ref _rotKeysData, value);
		}

		public animSplineCompressedMotionExtraction()
		{
			_duration = 1.000000F;
		}
	}
}
