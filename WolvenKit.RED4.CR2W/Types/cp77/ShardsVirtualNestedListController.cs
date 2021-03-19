using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardsVirtualNestedListController : VirtualNestedListController
	{
		private wCHandle<ShardsNestedListDataView> _currentDataView;

		[Ordinal(13)] 
		[RED("currentDataView")] 
		public wCHandle<ShardsNestedListDataView> CurrentDataView
		{
			get => GetProperty(ref _currentDataView);
			set => SetProperty(ref _currentDataView, value);
		}

		public ShardsVirtualNestedListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
