using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshChunkIndicesOffset : CVariable
	{
		[Ordinal(0)]  [RED("start")] public CUInt32 Start { get; set; }
		[Ordinal(1)]  [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(2)]  [RED("boneIndex")] public CUInt8 BoneIndex { get; set; }

		public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
