using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBoneTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("entries")] public CArray<animSetBoneTransformEntry> Entries { get; set; }

		public animAnimNode_SetBoneTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
