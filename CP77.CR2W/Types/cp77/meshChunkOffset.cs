using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshChunkOffset : CVariable
	{
		[Ordinal(0)]  [RED("chunkIndex")] public CUInt32 ChunkIndex { get; set; }
		[Ordinal(1)]  [RED("count")] public CUInt16 Count { get; set; }
		[Ordinal(2)]  [RED("start")] public CUInt16 Start { get; set; }

		public meshChunkOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
