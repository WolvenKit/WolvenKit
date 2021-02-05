using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AuthorizationData : CVariable
	{
		[Ordinal(0)]  [RED("isAuthorizationModuleOn")] public CBool IsAuthorizationModuleOn { get; set; }
		[Ordinal(1)]  [RED("alwaysExposeActions")] public CBool AlwaysExposeActions { get; set; }
		[Ordinal(2)]  [RED("authorizationDataEntry")] public SecurityAccessLevelEntryClient AuthorizationDataEntry { get; set; }

		public AuthorizationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
