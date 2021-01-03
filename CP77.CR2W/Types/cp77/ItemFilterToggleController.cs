using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemFilterToggleController : ToggleController
	{
		[Ordinal(0)]  [RED("newItemDot")] public inkWidgetReference NewItemDot { get; set; }
		[Ordinal(1)]  [RED("useCategoryFilter")] public CBool UseCategoryFilter { get; set; }

		public ItemFilterToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
