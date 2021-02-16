using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillchecks : ScannerChunk
	{
		[Ordinal(0)] [RED("skillchecks")] public CArray<UIInteractionSkillCheck> Skillchecks { get; set; }
		[Ordinal(1)] [RED("authorizationRequired")] public CBool AuthorizationRequired { get; set; }
		[Ordinal(2)] [RED("isPlayerAuthorized")] public CBool IsPlayerAuthorized { get; set; }

		public ScannerSkillchecks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
