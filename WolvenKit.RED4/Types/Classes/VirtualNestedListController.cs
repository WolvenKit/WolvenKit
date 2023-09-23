using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualNestedListController : inkVirtualListController
	{
		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<VirtualNestedListDataView> DataView
		{
			get => GetPropertyValue<CHandle<VirtualNestedListDataView>>();
			set => SetPropertyValue<CHandle<VirtualNestedListDataView>>(value);
		}

		[Ordinal(10)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(11)] 
		[RED("classifier")] 
		public CHandle<VirutalNestedListClassifier> Classifier
		{
			get => GetPropertyValue<CHandle<VirutalNestedListClassifier>>();
			set => SetPropertyValue<CHandle<VirutalNestedListClassifier>>(value);
		}

		[Ordinal(12)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public VirtualNestedListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
