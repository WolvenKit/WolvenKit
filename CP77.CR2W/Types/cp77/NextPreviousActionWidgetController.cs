using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NextPreviousActionWidgetController : DeviceActionWidgetControllerBase
	{
		[Ordinal(0)]  [RED("declineContainer")] public inkWidgetReference DeclineContainer { get; set; }
		[Ordinal(1)]  [RED("defaultContainer")] public inkWidgetReference DefaultContainer { get; set; }
		[Ordinal(2)]  [RED("isProcessing")] public CBool IsProcessing { get; set; }
		[Ordinal(3)]  [RED("moneyStatusAnimName")] public CName MoneyStatusAnimName { get; set; }

		public NextPreviousActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
