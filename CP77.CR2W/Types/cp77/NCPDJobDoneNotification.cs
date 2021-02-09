using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneNotification : JournalNotification
	{
		[Ordinal(13)]  [RED("NCPD_Reward")] public inkWidgetReference NCPD_Reward { get; set; }
		[Ordinal(14)]  [RED("NCPD_XP_RewardText")] public inkTextWidgetReference NCPD_XP_RewardText { get; set; }
		[Ordinal(15)]  [RED("NCPD_SC_RewardText")] public inkTextWidgetReference NCPD_SC_RewardText { get; set; }

		public NCPDJobDoneNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
