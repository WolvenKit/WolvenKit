using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PreventionNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("bountyAmountText")] public inkTextWidgetReference BountyAmountText { get; set; }
		[Ordinal(1)]  [RED("bountyTitleText")] public inkTextWidgetReference BountyTitleText { get; set; }
		[Ordinal(2)]  [RED("bounty_data")] public CHandle<PreventionBountyViewData> Bounty_data { get; set; }

		public PreventionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
