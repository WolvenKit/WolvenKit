using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("lineWidget")] public inkWidgetReference LineWidget { get; set; }

		public ItemTooltipModuleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
