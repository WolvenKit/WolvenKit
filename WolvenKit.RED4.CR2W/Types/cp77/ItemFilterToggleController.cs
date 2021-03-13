using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemFilterToggleController : ToggleController
	{
		[Ordinal(16)] [RED("newItemDot")] public inkWidgetReference NewItemDot { get; set; }
		[Ordinal(17)] [RED("useCategoryFilter")] public CBool UseCategoryFilter { get; set; }

		public ItemFilterToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
