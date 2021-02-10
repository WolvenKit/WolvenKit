using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(18)]  [RED("defaultContainer")] public inkWidgetReference DefaultContainer { get; set; }
		[Ordinal(19)]  [RED("declineContainer")] public inkWidgetReference DeclineContainer { get; set; }
		[Ordinal(20)]  [RED("moneyStatusAnimName")] public CName MoneyStatusAnimName { get; set; }
		[Ordinal(21)]  [RED("isProcessing")] public CBool IsProcessing { get; set; }

		public NextPreviousActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
