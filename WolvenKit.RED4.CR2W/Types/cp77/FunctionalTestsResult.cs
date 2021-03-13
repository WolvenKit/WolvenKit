using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsResult : CVariable
	{
		[Ordinal(0)] [RED("code")] public CEnum<FunctionalTestsResultCode> Code { get; set; }
		[Ordinal(1)] [RED("msg")] public CString Msg { get; set; }

		public FunctionalTestsResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
