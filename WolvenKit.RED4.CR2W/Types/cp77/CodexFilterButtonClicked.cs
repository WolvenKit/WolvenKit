using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexFilterButtonClicked : redEvent
	{
		[Ordinal(0)] [RED("category")] public CEnum<CodexCategoryType> Category { get; set; }
		[Ordinal(1)] [RED("toggled")] public CBool Toggled { get; set; }

		public CodexFilterButtonClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
