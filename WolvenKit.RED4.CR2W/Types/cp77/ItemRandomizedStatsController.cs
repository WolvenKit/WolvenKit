using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemRandomizedStatsController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("statName")] public inkTextWidgetReference StatName { get; set; }

		public ItemRandomizedStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
