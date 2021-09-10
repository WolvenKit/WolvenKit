using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardsVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<ShardsNestedListDataView> CurrentDataView
		{
			get => GetPropertyValue<CWeakHandle<ShardsNestedListDataView>>();
			set => SetPropertyValue<CWeakHandle<ShardsNestedListDataView>>(value);
		}
	}
}
