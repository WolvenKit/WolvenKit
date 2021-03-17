using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataTimeStatsData : ISerializable
	{
		private CUInt64 _engineTick;
		private CFloat _lastFps;
		private CFloat _minFps;
		private CFloat _lastTimeDelta;
		private CDouble _engineTime;
		private CFloat _cpuTime;
		private CFloat _gpuTime;
		private CUInt64 _rawLocalTime;
		private CString _playerPosition;
		private CString _playerOrientation;

		[Ordinal(0)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get => GetProperty(ref _engineTick);
			set => SetProperty(ref _engineTick, value);
		}

		[Ordinal(1)] 
		[RED("lastFps")] 
		public CFloat LastFps
		{
			get => GetProperty(ref _lastFps);
			set => SetProperty(ref _lastFps, value);
		}

		[Ordinal(2)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetProperty(ref _minFps);
			set => SetProperty(ref _minFps, value);
		}

		[Ordinal(3)] 
		[RED("lastTimeDelta")] 
		public CFloat LastTimeDelta
		{
			get => GetProperty(ref _lastTimeDelta);
			set => SetProperty(ref _lastTimeDelta, value);
		}

		[Ordinal(4)] 
		[RED("engineTime")] 
		public CDouble EngineTime
		{
			get => GetProperty(ref _engineTime);
			set => SetProperty(ref _engineTime, value);
		}

		[Ordinal(5)] 
		[RED("cpuTime")] 
		public CFloat CpuTime
		{
			get => GetProperty(ref _cpuTime);
			set => SetProperty(ref _cpuTime, value);
		}

		[Ordinal(6)] 
		[RED("gpuTime")] 
		public CFloat GpuTime
		{
			get => GetProperty(ref _gpuTime);
			set => SetProperty(ref _gpuTime, value);
		}

		[Ordinal(7)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetProperty(ref _rawLocalTime);
			set => SetProperty(ref _rawLocalTime, value);
		}

		[Ordinal(8)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetProperty(ref _playerPosition);
			set => SetProperty(ref _playerPosition, value);
		}

		[Ordinal(9)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetProperty(ref _playerOrientation);
			set => SetProperty(ref _playerOrientation, value);
		}

		public FunctionalTestsDataTimeStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
