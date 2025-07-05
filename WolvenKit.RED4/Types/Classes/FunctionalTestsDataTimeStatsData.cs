using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsDataTimeStatsData : ISerializable
	{
		[Ordinal(0)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("lastFps")] 
		public CFloat LastFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lastTimeDelta")] 
		public CFloat LastTimeDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("engineTime")] 
		public CDouble EngineTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(5)] 
		[RED("cpuTime")] 
		public CFloat CpuTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("gpuTime")] 
		public CFloat GpuTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(8)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public FunctionalTestsDataTimeStatsData()
		{
			EngineTime = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
