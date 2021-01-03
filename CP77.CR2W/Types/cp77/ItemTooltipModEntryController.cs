using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModEntryController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("modName")] public inkTextWidgetReference ModName { get; set; }

		public ItemTooltipModEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
