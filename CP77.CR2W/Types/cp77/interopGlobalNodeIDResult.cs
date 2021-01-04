using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopGlobalNodeIDResult : CVariable
	{
		[Ordinal(0)]  [RED("errorMessage")] public CString ErrorMessage { get; set; }
		[Ordinal(1)]  [RED("isValid")] public CBool IsValid { get; set; }
		[Ordinal(2)]  [RED("result")] public CString Result { get; set; }

		public interopGlobalNodeIDResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
