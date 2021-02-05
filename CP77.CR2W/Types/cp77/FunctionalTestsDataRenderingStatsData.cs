using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataRenderingStatsData : ISerializable
	{
		[Ordinal(0)]  [RED("engineTick")] public CUInt64 EngineTick { get; set; }
		[Ordinal(1)]  [RED("rawLocalTime")] public CUInt64 RawLocalTime { get; set; }
		[Ordinal(2)]  [RED("playerPosition")] public CString PlayerPosition { get; set; }
		[Ordinal(3)]  [RED("playerOrientation")] public CString PlayerOrientation { get; set; }
		[Ordinal(4)]  [RED("meshChunkCount")] public CUInt32 MeshChunkCount { get; set; }
		[Ordinal(5)]  [RED("cameraTriangleCount")] public CUInt32 CameraTriangleCount { get; set; }
		[Ordinal(6)]  [RED("shadowTriangleCount")] public CUInt32 ShadowTriangleCount { get; set; }

		public FunctionalTestsDataRenderingStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
