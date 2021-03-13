using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workStopWorkspotQuestAction : workIWorkspotQuestAction
	{
		[Ordinal(0)] [RED("allowCurrAnimToFinish")] public CBool AllowCurrAnimToFinish { get; set; }
		[Ordinal(1)] [RED("exitAnim")] public CName ExitAnim { get; set; }

		public workStopWorkspotQuestAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
