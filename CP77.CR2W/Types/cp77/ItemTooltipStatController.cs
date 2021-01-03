using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(1)]  [RED("statComparedContainer")] public inkWidgetReference StatComparedContainer { get; set; }
		[Ordinal(2)]  [RED("statComparedValue")] public inkTextWidgetReference StatComparedValue { get; set; }
		[Ordinal(3)]  [RED("statName")] public inkTextWidgetReference StatName { get; set; }
		[Ordinal(4)]  [RED("statValue")] public inkTextWidgetReference StatValue { get; set; }

		public ItemTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
