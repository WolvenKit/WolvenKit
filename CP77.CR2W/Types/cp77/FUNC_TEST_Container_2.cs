using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_Container_2 : CVariable
	{
		[Ordinal(0)] [RED("FloatBox")] public CFloat FloatBox { get; set; }
		[Ordinal(1)] [RED("IntBox")] public CInt32 IntBox { get; set; }
		[Ordinal(2)] [RED("BoolBox")] public CBool BoolBox { get; set; }
		[Ordinal(3)] [RED("NameBox")] public CName NameBox { get; set; }
		[Ordinal(4)] [RED("StringBox")] public CString StringBox { get; set; }
		[Ordinal(5)] [RED("CNameBox")] public CName CNameBox { get; set; }
		[Ordinal(6)] [RED("TweakBox")] public TweakDBID TweakBox { get; set; }

		public FUNC_TEST_Container_2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
