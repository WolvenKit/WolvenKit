using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexFilterButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(2)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(3)] [RED("category")] public CEnum<CodexCategoryType> Category { get; set; }
		[Ordinal(4)] [RED("toggled")] public CBool Toggled { get; set; }
		[Ordinal(5)] [RED("hovered")] public CBool Hovered { get; set; }

		public CodexFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
