using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexFilterButtonController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("category")] public CEnum<CodexCategoryType> Category { get; set; }
		[Ordinal(1)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(2)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(3)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(4)]  [RED("toggled")] public CBool Toggled { get; set; }

		public CodexFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
