using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneNotification : JournalNotification
	{
		[Ordinal(16)] [RED("NCPD_Reward")] public inkWidgetReference NCPD_Reward { get; set; }
		[Ordinal(17)] [RED("NCPD_XP_RewardText")] public inkTextWidgetReference NCPD_XP_RewardText { get; set; }
		[Ordinal(18)] [RED("NCPD_SC_RewardText")] public inkTextWidgetReference NCPD_SC_RewardText { get; set; }

		public NCPDJobDoneNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
