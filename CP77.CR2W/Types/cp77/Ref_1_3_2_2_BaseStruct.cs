using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_2_BaseStruct : CVariable
	{
		[Ordinal(0)] [RED("prop1")] public CInt32 Prop1 { get; set; }

		public Ref_1_3_2_2_BaseStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
