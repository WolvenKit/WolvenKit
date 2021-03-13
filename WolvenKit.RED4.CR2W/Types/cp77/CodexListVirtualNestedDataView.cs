using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualNestedDataView : VirtualNestedListDataView
	{
		[Ordinal(3)] [RED("currentFilter")] public CEnum<CodexCategoryType> CurrentFilter { get; set; }

		public CodexListVirtualNestedDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
