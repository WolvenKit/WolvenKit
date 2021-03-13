using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_15 : CVariable
	{
		[Ordinal(0)] [RED("var0")] public CFloat Var0 { get; set; }
		[Ordinal(1)] [RED("var1")] public CFloat Var1 { get; set; }
		[Ordinal(2)] [RED("var2")] public CInt32 Var2 { get; set; }
		[Ordinal(3)] [RED("var3")] public CInt32 Var3 { get; set; }

		public Sample_Class_2_15(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
