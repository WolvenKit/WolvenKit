using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataTimeStatsData : ISerializable
	{
		[Ordinal(0)]  [RED("engineTick")] public CUInt64 EngineTick { get; set; }
		[Ordinal(1)]  [RED("lastFps")] public CFloat LastFps { get; set; }
		[Ordinal(2)]  [RED("minFps")] public CFloat MinFps { get; set; }
		[Ordinal(3)]  [RED("lastTimeDelta")] public CFloat LastTimeDelta { get; set; }
		[Ordinal(4)]  [RED("engineTime")] public CDouble EngineTime { get; set; }
		[Ordinal(5)]  [RED("cpuTime")] public CFloat CpuTime { get; set; }
		[Ordinal(6)]  [RED("gpuTime")] public CFloat GpuTime { get; set; }
		[Ordinal(7)]  [RED("rawLocalTime")] public CUInt64 RawLocalTime { get; set; }
		[Ordinal(8)]  [RED("playerPosition")] public CString PlayerPosition { get; set; }
		[Ordinal(9)]  [RED("playerOrientation")] public CString PlayerOrientation { get; set; }

		public FunctionalTestsDataTimeStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
