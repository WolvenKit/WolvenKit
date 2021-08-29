using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVideoWidgetSummary : RedBaseClass
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _currentTimeMs;
		private CUInt32 _totalTimeMs;
		private CUInt32 _currentFrame;
		private CUInt32 _totalFrames;
		private CUInt32 _frameRate;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(2)] 
		[RED("currentTimeMs")] 
		public CUInt32 CurrentTimeMs
		{
			get => GetProperty(ref _currentTimeMs);
			set => SetProperty(ref _currentTimeMs, value);
		}

		[Ordinal(3)] 
		[RED("totalTimeMs")] 
		public CUInt32 TotalTimeMs
		{
			get => GetProperty(ref _totalTimeMs);
			set => SetProperty(ref _totalTimeMs, value);
		}

		[Ordinal(4)] 
		[RED("currentFrame")] 
		public CUInt32 CurrentFrame
		{
			get => GetProperty(ref _currentFrame);
			set => SetProperty(ref _currentFrame, value);
		}

		[Ordinal(5)] 
		[RED("totalFrames")] 
		public CUInt32 TotalFrames
		{
			get => GetProperty(ref _totalFrames);
			set => SetProperty(ref _totalFrames, value);
		}

		[Ordinal(6)] 
		[RED("frameRate")] 
		public CUInt32 FrameRate
		{
			get => GetProperty(ref _frameRate);
			set => SetProperty(ref _frameRate, value);
		}
	}
}
