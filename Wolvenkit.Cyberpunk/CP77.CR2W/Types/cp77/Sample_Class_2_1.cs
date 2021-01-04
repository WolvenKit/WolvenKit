using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_1 : CVariable
	{
		[Ordinal(0)]  [RED("var0")] public CInt32 Var0 { get; set; }
		[Ordinal(1)]  [RED("var1")] public CFloat Var1 { get; set; }
		[Ordinal(2)]  [RED("var2")] public CString Var2 { get; set; }
		[Ordinal(3)]  [RED("var3")] public CName Var3 { get; set; }

		public Sample_Class_2_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
