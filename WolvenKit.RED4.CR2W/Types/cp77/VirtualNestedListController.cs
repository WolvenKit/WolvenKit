using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListController : inkVirtualListController
	{
		[Ordinal(8)] [RED("dataView")] public CHandle<VirtualNestedListDataView> DataView { get; set; }
		[Ordinal(9)] [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(10)] [RED("classifier")] public CHandle<VirutalNestedListClassifier> Classifier { get; set; }
		[Ordinal(11)] [RED("defaultCollapsed")] public CBool DefaultCollapsed { get; set; }
		[Ordinal(12)] [RED("toggledLevels")] public CArray<CInt32> ToggledLevels { get; set; }

		public VirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
