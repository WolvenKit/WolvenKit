using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexLockRecordRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("codexRecordID")] public TweakDBID CodexRecordID { get; set; }

		public CodexLockRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
