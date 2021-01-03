using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualNestedDataView : VirtualNestedListDataView
	{
		[Ordinal(0)]  [RED("currentFilter")] public CEnum<CodexCategoryType> CurrentFilter { get; set; }

		public CodexListVirtualNestedDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
