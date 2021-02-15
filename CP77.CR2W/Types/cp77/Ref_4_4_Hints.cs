using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_4_4_Hints : CVariable
	{
		[Ordinal(0)] [RED("i")] public CInt32 I { get; set; }
		[Ordinal(1)] [RED("f")] public CFloat F { get; set; }
		[Ordinal(2)] [RED("b")] public CBool B { get; set; }
		[Ordinal(3)] [RED("s")] public CString S { get; set; }

		public Ref_4_4_Hints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
