using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryStatsData : ISerializable
	{
		[Ordinal(0)] [RED("totalPhysicalMemory")] public CUInt64 TotalPhysicalMemory { get; set; }
		[Ordinal(1)] [RED("availablePhysicalMemory")] public CUInt64 AvailablePhysicalMemory { get; set; }
		[Ordinal(2)] [RED("runtimeTotalBytesAllocated")] public CUInt64 RuntimeTotalBytesAllocated { get; set; }
		[Ordinal(3)] [RED("cpuBytesAllocated")] public CUInt64 CpuBytesAllocated { get; set; }
		[Ordinal(4)] [RED("gpuBytesAllocated")] public CUInt64 GpuBytesAllocated { get; set; }
		[Ordinal(5)] [RED("totalAllocationCount")] public CUInt32 TotalAllocationCount { get; set; }
		[Ordinal(6)] [RED("cpuAllocationCount")] public CUInt32 CpuAllocationCount { get; set; }
		[Ordinal(7)] [RED("gpuAllocationCount")] public CUInt32 GpuAllocationCount { get; set; }
		[Ordinal(8)] [RED("engineTick")] public CUInt64 EngineTick { get; set; }
		[Ordinal(9)] [RED("lastTimeDelta")] public CFloat LastTimeDelta { get; set; }
		[Ordinal(10)] [RED("engineTime")] public CDouble EngineTime { get; set; }
		[Ordinal(11)] [RED("rawLocalTime")] public CUInt64 RawLocalTime { get; set; }
		[Ordinal(12)] [RED("playerPosition")] public CString PlayerPosition { get; set; }
		[Ordinal(13)] [RED("playerOrientation")] public CString PlayerOrientation { get; set; }
		[Ordinal(14)] [RED("poolsRuntimeInfo")] public CArray<FunctionalTestsDataMemoryPoolRuntimeData> PoolsRuntimeInfo { get; set; }
		[Ordinal(15)] [RED("poolsCurrentInfo")] public CArray<FunctionalTestsDataMemoryPoolStaticData> PoolsCurrentInfo { get; set; }

		public FunctionalTestsDataMemoryStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
