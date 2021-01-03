using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animBoneCorrection : CVariable
	{
		[Ordinal(0)]  [RED("additiveCorrection")] public Quaternion AdditiveCorrection { get; set; }
		[Ordinal(1)]  [RED("boneName")] public CName BoneName { get; set; }

		public animBoneCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
