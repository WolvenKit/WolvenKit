using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workStopWorkspotQuestAction : workIWorkspotQuestAction
	{
		[Ordinal(0)]  [RED("allowCurrAnimToFinish")] public CBool AllowCurrAnimToFinish { get; set; }
		[Ordinal(1)]  [RED("exitAnim")] public CName ExitAnim { get; set; }

		public workStopWorkspotQuestAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
