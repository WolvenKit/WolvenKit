using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardsVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(0)]  [RED("currentDataView")] public wCHandle<ShardsNestedListDataView> CurrentDataView { get; set; }

		public ShardsVirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
