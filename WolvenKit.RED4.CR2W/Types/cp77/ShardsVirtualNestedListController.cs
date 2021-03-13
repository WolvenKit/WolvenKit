using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardsVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(13)] [RED("currentDataView")] public wCHandle<ShardsNestedListDataView> CurrentDataView { get; set; }

		public ShardsVirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
