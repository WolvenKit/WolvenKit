using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] [RED("compareBuilder")] public CHandle<CompareBuilder> CompareBuilder { get; set; }
		[Ordinal(1)] [RED("defaultCollapsed")] public CBool DefaultCollapsed { get; set; }
		[Ordinal(2)] [RED("toggledLevels")] public CArray<CInt32> ToggledLevels { get; set; }

		public VirtualNestedListDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
