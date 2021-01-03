using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillchecks : ScannerChunk
	{
		[Ordinal(0)]  [RED("authorizationRequired")] public CBool AuthorizationRequired { get; set; }
		[Ordinal(1)]  [RED("isPlayerAuthorized")] public CBool IsPlayerAuthorized { get; set; }
		[Ordinal(2)]  [RED("skillchecks")] public CArray<UIInteractionSkillCheck> Skillchecks { get; set; }

		public ScannerSkillchecks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
