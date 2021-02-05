using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(0)]  [RED("dataView")] public CHandle<VirtualNestedListDataView> DataView { get; set; }
		[Ordinal(1)]  [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(2)]  [RED("classifier")] public CHandle<VirutalNestedListClassifier> Classifier { get; set; }
		[Ordinal(3)]  [RED("defaultCollapsed")] public CBool DefaultCollapsed { get; set; }
		[Ordinal(4)]  [RED("toggledLevels")] public CArray<CInt32> ToggledLevels { get; set; }
		[Ordinal(5)]  [RED("currentDataView")] public wCHandle<CodexListVirtualNestedDataView> CurrentDataView { get; set; }

		public CodexListVirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
