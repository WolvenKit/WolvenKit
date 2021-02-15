using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_2_2_7_Struct : CVariable
	{
		[Ordinal(0)] [RED("val")] public CInt32 Val { get; set; }

		public Ref_2_2_7_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
