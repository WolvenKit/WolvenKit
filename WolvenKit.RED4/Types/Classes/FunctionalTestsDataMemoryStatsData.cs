using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsDataMemoryStatsData : ISerializable
	{
		[Ordinal(0)] 
		[RED("totalPhysicalMemory")] 
		public CUInt64 TotalPhysicalMemory
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("availablePhysicalMemory")] 
		public CUInt64 AvailablePhysicalMemory
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("runtimeTotalBytesAllocated")] 
		public CUInt64 RuntimeTotalBytesAllocated
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("cpuBytesAllocated")] 
		public CUInt64 CpuBytesAllocated
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("gpuBytesAllocated")] 
		public CUInt64 GpuBytesAllocated
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(5)] 
		[RED("totalAllocationCount")] 
		public CUInt32 TotalAllocationCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("cpuAllocationCount")] 
		public CUInt32 CpuAllocationCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("gpuAllocationCount")] 
		public CUInt32 GpuAllocationCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(9)] 
		[RED("lastTimeDelta")] 
		public CFloat LastTimeDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("engineTime")] 
		public CDouble EngineTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(11)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(12)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("poolsRuntimeInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolRuntimeData> PoolsRuntimeInfo
		{
			get => GetPropertyValue<CArray<FunctionalTestsDataMemoryPoolRuntimeData>>();
			set => SetPropertyValue<CArray<FunctionalTestsDataMemoryPoolRuntimeData>>(value);
		}

		[Ordinal(15)] 
		[RED("poolsCurrentInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolStaticData> PoolsCurrentInfo
		{
			get => GetPropertyValue<CArray<FunctionalTestsDataMemoryPoolStaticData>>();
			set => SetPropertyValue<CArray<FunctionalTestsDataMemoryPoolStaticData>>(value);
		}

		public FunctionalTestsDataMemoryStatsData()
		{
			EngineTime = 0.000000;
			PoolsRuntimeInfo = new();
			PoolsCurrentInfo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
