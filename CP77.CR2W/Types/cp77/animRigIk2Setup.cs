using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRigIk2Setup : animIRigIkSetup
	{
		[Ordinal(0)]  [RED("endBone")] public CName EndBone { get; set; }
		[Ordinal(1)]  [RED("endBoneIdx")] public CInt16 EndBoneIdx { get; set; }
		[Ordinal(2)]  [RED("firstBone")] public CName FirstBone { get; set; }
		[Ordinal(3)]  [RED("firstBoneIdx")] public CInt16 FirstBoneIdx { get; set; }
		[Ordinal(4)]  [RED("hingeAxis")] public CEnum<animAxis> HingeAxis { get; set; }
		[Ordinal(5)]  [RED("secondBone")] public CName SecondBone { get; set; }
		[Ordinal(6)]  [RED("secondBoneIdx")] public CInt16 SecondBoneIdx { get; set; }

		public animRigIk2Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
