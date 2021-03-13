using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkIndicesOffset : CVariable
	{
		[Ordinal(0)] [RED("start")] public CUInt32 Start { get; set; }
		[Ordinal(1)] [RED("count")] public CUInt32 Count { get; set; }
		[Ordinal(2)] [RED("boneIndex")] public CUInt8 BoneIndex { get; set; }

		public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
