using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workStopWorkspotQuestAction : workIWorkspotQuestAction
	{
		[Ordinal(0)]  [RED("exitAnim")] public CName ExitAnim { get; set; }
		[Ordinal(1)]  [RED("allowCurrAnimToFinish")] public CBool AllowCurrAnimToFinish { get; set; }

		public workStopWorkspotQuestAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
