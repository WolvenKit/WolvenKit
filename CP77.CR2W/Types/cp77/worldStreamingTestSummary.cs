using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStreamingTestSummary : ISerializable
	{
		[Ordinal(0)]  [RED("bytesReadDuringCooldown")] public CUInt64 BytesReadDuringCooldown { get; set; }
		[Ordinal(1)]  [RED("bytesReadDuringDriving")] public CUInt64 BytesReadDuringDriving { get; set; }
		[Ordinal(2)]  [RED("bytesReadDuringTest")] public CUInt64 BytesReadDuringTest { get; set; }
		[Ordinal(3)]  [RED("gameDefinition")] public CString GameDefinition { get; set; }
		[Ordinal(4)]  [RED("initialBytesRead")] public CUInt64 InitialBytesRead { get; set; }
		[Ordinal(5)]  [RED("noCrowds")] public CBool NoCrowds { get; set; }
		[Ordinal(6)]  [RED("testDurationSeconds")] public CFloat TestDurationSeconds { get; set; }
		[Ordinal(7)]  [RED("totalSeeksBytes")] public CUInt64 TotalSeeksBytes { get; set; }

		public worldStreamingTestSummary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
