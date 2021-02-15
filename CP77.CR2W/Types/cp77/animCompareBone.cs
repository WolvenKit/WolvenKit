using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCompareBone : CVariable
	{
		[Ordinal(0)] [RED("boneName")] public CName BoneName { get; set; }
		[Ordinal(1)] [RED("boneRotationLs")] public Quaternion BoneRotationLs { get; set; }

		public animCompareBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
