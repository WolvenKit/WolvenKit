using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRigPartBoneTree : CVariable
	{
		[Ordinal(0)] [RED("rootBone")] public CName RootBone { get; set; }
		[Ordinal(1)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(2)] [RED("subtreesToChange")] public CArray<animRigPartBoneTree> SubtreesToChange { get; set; }

		public animRigPartBoneTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
