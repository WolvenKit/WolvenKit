using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelBarsController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("bar0")] public inkWidgetReference Bar0 { get; set; }
		[Ordinal(2)] [RED("bar1")] public inkWidgetReference Bar1 { get; set; }
		[Ordinal(3)] [RED("bar2")] public inkWidgetReference Bar2 { get; set; }
		[Ordinal(4)] [RED("bar3")] public inkWidgetReference Bar3 { get; set; }
		[Ordinal(5)] [RED("bar4")] public inkWidgetReference Bar4 { get; set; }
		[Ordinal(6)] [RED("bars", 5)] public CArrayFixedSize<inkWidgetReference> Bars { get; set; }

		public LevelBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
