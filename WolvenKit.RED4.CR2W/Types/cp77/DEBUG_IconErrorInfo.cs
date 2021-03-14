using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_IconErrorInfo : IScriptable
	{
		[Ordinal(0)] [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(1)] [RED("innerItemName")] public CString InnerItemName { get; set; }
		[Ordinal(2)] [RED("resolvedIconName")] public CString ResolvedIconName { get; set; }
		[Ordinal(3)] [RED("errorMessage")] public CString ErrorMessage { get; set; }
		[Ordinal(4)] [RED("errorType")] public CEnum<inkIconResult> ErrorType { get; set; }
		[Ordinal(5)] [RED("isManuallySet")] public CBool IsManuallySet { get; set; }

		public DEBUG_IconErrorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
