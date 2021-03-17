using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryStatsData : ISerializable
	{
		private CUInt64 _totalPhysicalMemory;
		private CUInt64 _availablePhysicalMemory;
		private CUInt64 _runtimeTotalBytesAllocated;
		private CUInt64 _cpuBytesAllocated;
		private CUInt64 _gpuBytesAllocated;
		private CUInt32 _totalAllocationCount;
		private CUInt32 _cpuAllocationCount;
		private CUInt32 _gpuAllocationCount;
		private CUInt64 _engineTick;
		private CFloat _lastTimeDelta;
		private CDouble _engineTime;
		private CUInt64 _rawLocalTime;
		private CString _playerPosition;
		private CString _playerOrientation;
		private CArray<FunctionalTestsDataMemoryPoolRuntimeData> _poolsRuntimeInfo;
		private CArray<FunctionalTestsDataMemoryPoolStaticData> _poolsCurrentInfo;

		[Ordinal(0)] 
		[RED("totalPhysicalMemory")] 
		public CUInt64 TotalPhysicalMemory
		{
			get => GetProperty(ref _totalPhysicalMemory);
			set => SetProperty(ref _totalPhysicalMemory, value);
		}

		[Ordinal(1)] 
		[RED("availablePhysicalMemory")] 
		public CUInt64 AvailablePhysicalMemory
		{
			get => GetProperty(ref _availablePhysicalMemory);
			set => SetProperty(ref _availablePhysicalMemory, value);
		}

		[Ordinal(2)] 
		[RED("runtimeTotalBytesAllocated")] 
		public CUInt64 RuntimeTotalBytesAllocated
		{
			get => GetProperty(ref _runtimeTotalBytesAllocated);
			set => SetProperty(ref _runtimeTotalBytesAllocated, value);
		}

		[Ordinal(3)] 
		[RED("cpuBytesAllocated")] 
		public CUInt64 CpuBytesAllocated
		{
			get => GetProperty(ref _cpuBytesAllocated);
			set => SetProperty(ref _cpuBytesAllocated, value);
		}

		[Ordinal(4)] 
		[RED("gpuBytesAllocated")] 
		public CUInt64 GpuBytesAllocated
		{
			get => GetProperty(ref _gpuBytesAllocated);
			set => SetProperty(ref _gpuBytesAllocated, value);
		}

		[Ordinal(5)] 
		[RED("totalAllocationCount")] 
		public CUInt32 TotalAllocationCount
		{
			get => GetProperty(ref _totalAllocationCount);
			set => SetProperty(ref _totalAllocationCount, value);
		}

		[Ordinal(6)] 
		[RED("cpuAllocationCount")] 
		public CUInt32 CpuAllocationCount
		{
			get => GetProperty(ref _cpuAllocationCount);
			set => SetProperty(ref _cpuAllocationCount, value);
		}

		[Ordinal(7)] 
		[RED("gpuAllocationCount")] 
		public CUInt32 GpuAllocationCount
		{
			get => GetProperty(ref _gpuAllocationCount);
			set => SetProperty(ref _gpuAllocationCount, value);
		}

		[Ordinal(8)] 
		[RED("engineTick")] 
		public CUInt64 EngineTick
		{
			get => GetProperty(ref _engineTick);
			set => SetProperty(ref _engineTick, value);
		}

		[Ordinal(9)] 
		[RED("lastTimeDelta")] 
		public CFloat LastTimeDelta
		{
			get => GetProperty(ref _lastTimeDelta);
			set => SetProperty(ref _lastTimeDelta, value);
		}

		[Ordinal(10)] 
		[RED("engineTime")] 
		public CDouble EngineTime
		{
			get => GetProperty(ref _engineTime);
			set => SetProperty(ref _engineTime, value);
		}

		[Ordinal(11)] 
		[RED("rawLocalTime")] 
		public CUInt64 RawLocalTime
		{
			get => GetProperty(ref _rawLocalTime);
			set => SetProperty(ref _rawLocalTime, value);
		}

		[Ordinal(12)] 
		[RED("playerPosition")] 
		public CString PlayerPosition
		{
			get => GetProperty(ref _playerPosition);
			set => SetProperty(ref _playerPosition, value);
		}

		[Ordinal(13)] 
		[RED("playerOrientation")] 
		public CString PlayerOrientation
		{
			get => GetProperty(ref _playerOrientation);
			set => SetProperty(ref _playerOrientation, value);
		}

		[Ordinal(14)] 
		[RED("poolsRuntimeInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolRuntimeData> PoolsRuntimeInfo
		{
			get => GetProperty(ref _poolsRuntimeInfo);
			set => SetProperty(ref _poolsRuntimeInfo, value);
		}

		[Ordinal(15)] 
		[RED("poolsCurrentInfo")] 
		public CArray<FunctionalTestsDataMemoryPoolStaticData> PoolsCurrentInfo
		{
			get => GetProperty(ref _poolsCurrentInfo);
			set => SetProperty(ref _poolsCurrentInfo, value);
		}

		public FunctionalTestsDataMemoryStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
