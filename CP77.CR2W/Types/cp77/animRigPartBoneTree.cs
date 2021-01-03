using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animRigPartBoneTree : CVariable
	{
		[Ordinal(0)]  [RED("rootBone")] public CName RootBone { get; set; }
		[Ordinal(1)]  [RED("subtreesToChange")] public CArray<animRigPartBoneTree> SubtreesToChange { get; set; }
		[Ordinal(2)]  [RED("weight")] public CFloat Weight { get; set; }

		public animRigPartBoneTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
