using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LODBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("levelOfDetail")] public CUInt32 LevelOfDetail { get; set; }

		public animAnimNode_LODBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
