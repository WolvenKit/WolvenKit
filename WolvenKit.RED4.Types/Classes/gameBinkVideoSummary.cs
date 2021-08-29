using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBinkVideoSummary : RedBaseClass
	{
		private CUInt32 _currentTimeMs;
		private CUInt32 _totalTimeMs;
		private CUInt32 _currentFrame;
		private CUInt32 _totalFrames;
		private CUInt32 _frameRate;

		[Ordinal(0)] 
		[RED("currentTimeMs")] 
		public CUInt32 CurrentTimeMs
		{
			get => GetProperty(ref _currentTimeMs);
			set => SetProperty(ref _currentTimeMs, value);
		}

		[Ordinal(1)] 
		[RED("totalTimeMs")] 
		public CUInt32 TotalTimeMs
		{
			get => GetProperty(ref _totalTimeMs);
			set => SetProperty(ref _totalTimeMs, value);
		}

		[Ordinal(2)] 
		[RED("currentFrame")] 
		public CUInt32 CurrentFrame
		{
			get => GetProperty(ref _currentFrame);
			set => SetProperty(ref _currentFrame, value);
		}

		[Ordinal(3)] 
		[RED("totalFrames")] 
		public CUInt32 TotalFrames
		{
			get => GetProperty(ref _totalFrames);
			set => SetProperty(ref _totalFrames, value);
		}

		[Ordinal(4)] 
		[RED("frameRate")] 
		public CUInt32 FrameRate
		{
			get => GetProperty(ref _frameRate);
			set => SetProperty(ref _frameRate, value);
		}
	}
}
