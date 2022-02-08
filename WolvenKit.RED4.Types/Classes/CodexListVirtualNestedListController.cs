using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListVirtualNestedListController : VirtualNestedListController
	{
		[Ordinal(14)] 
		[RED("currentDataView")] 
		public CWeakHandle<CodexListVirtualNestedDataView> CurrentDataView
		{
			get => GetPropertyValue<CWeakHandle<CodexListVirtualNestedDataView>>();
			set => SetPropertyValue<CWeakHandle<CodexListVirtualNestedDataView>>(value);
		}
	}
}
