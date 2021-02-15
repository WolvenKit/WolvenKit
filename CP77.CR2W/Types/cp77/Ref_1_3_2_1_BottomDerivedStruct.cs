using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_BottomDerivedStruct : Ref_1_3_2_1_DerivedStruct
	{
		[Ordinal(2)] [RED("bottomDerivedProp")] public CBool BottomDerivedProp { get; set; }

		public Ref_1_3_2_1_BottomDerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
