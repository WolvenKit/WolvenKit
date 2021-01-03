using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LevelBarsController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bar0")] public inkWidgetReference Bar0 { get; set; }
		[Ordinal(1)]  [RED("bar1")] public inkWidgetReference Bar1 { get; set; }
		[Ordinal(2)]  [RED("bar2")] public inkWidgetReference Bar2 { get; set; }
		[Ordinal(3)]  [RED("bar3")] public inkWidgetReference Bar3 { get; set; }
		[Ordinal(4)]  [RED("bar4")] public inkWidgetReference Bar4 { get; set; }
		[Ordinal(5)]  [RED("bars")] public [5]inkWidgetReference Bars { get; set; }

		public LevelBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
