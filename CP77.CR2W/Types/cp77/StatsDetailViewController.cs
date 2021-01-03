using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatsDetailViewController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("StatLabelRef")] public inkTextWidgetReference StatLabelRef { get; set; }
		[Ordinal(1)]  [RED("StatValueRef")] public inkTextWidgetReference StatValueRef { get; set; }

		public StatsDetailViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
