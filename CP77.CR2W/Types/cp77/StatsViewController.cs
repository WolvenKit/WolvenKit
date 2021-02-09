using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsViewController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("StatLabelRef")] public inkTextWidgetReference StatLabelRef { get; set; }
		[Ordinal(1)]  [RED("StatValueRef")] public inkTextWidgetReference StatValueRef { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("stat")] public gameStatViewData Stat { get; set; }
		[Ordinal(4)]  [RED("buttonConctroller")] public wCHandle<inkButtonController> ButtonConctroller { get; set; }

		public StatsViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
