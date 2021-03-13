using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetCompressedInputStates : CVariable
	{
		[Ordinal(0)] [RED("usesCompression")] public CBool UsesCompression { get; set; }
		[Ordinal(1)] [RED("compressedInputStates")] public CArray<CUInt8> CompressedInputStates { get; set; }
		[Ordinal(2)] [RED("firstFrameId")] public CUInt32 FirstFrameId { get; set; }
		[Ordinal(3)] [RED("replicationTime")] public netTime ReplicationTime { get; set; }

		public gameMuppetCompressedInputStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
