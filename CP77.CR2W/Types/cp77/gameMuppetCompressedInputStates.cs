using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetCompressedInputStates : CVariable
	{
		[Ordinal(0)]  [RED("compressedInputStates")] public CArray<CUInt8> CompressedInputStates { get; set; }
		[Ordinal(1)]  [RED("firstFrameId")] public CUInt32 FirstFrameId { get; set; }
		[Ordinal(2)]  [RED("replicationTime")] public netTime ReplicationTime { get; set; }
		[Ordinal(3)]  [RED("usesCompression")] public CBool UsesCompression { get; set; }

		public gameMuppetCompressedInputStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
