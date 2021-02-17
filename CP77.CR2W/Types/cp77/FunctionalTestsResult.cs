using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsResult : CVariable
	{
		[Ordinal(0)] [RED("code")] public CEnum<FunctionalTestsResultCode> Code { get; set; }
		[Ordinal(1)] [RED("msg")] public CString Msg { get; set; }

		public FunctionalTestsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
