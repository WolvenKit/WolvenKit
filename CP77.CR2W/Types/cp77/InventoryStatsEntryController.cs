using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsEntryController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(1)]  [RED("labelWidget")] public inkTextWidgetReference LabelWidget { get; set; }
		[Ordinal(2)]  [RED("valueWidget")] public inkTextWidgetReference ValueWidget { get; set; }

		public InventoryStatsEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
