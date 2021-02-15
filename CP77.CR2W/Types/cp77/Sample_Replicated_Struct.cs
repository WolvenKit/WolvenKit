using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Struct : CVariable
	{
		[Ordinal(0)] [RED("a")] public CBool A { get; set; }
		[Ordinal(1)] [RED("b")] public CBool B { get; set; }
		[Ordinal(2)] [RED("c")] public CBool C { get; set; }
		[Ordinal(3)] [RED("d_not_replicated_still_OK")] public CBool D_not_replicated_still_OK { get; set; }

		public Sample_Replicated_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
