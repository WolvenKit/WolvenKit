using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualNestedListController : inkVirtualListController
	{
		private CHandle<VirtualNestedListDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<VirutalNestedListClassifier> _classifier;
		private CBool _defaultCollapsed;
		private CArray<CInt32> _toggledLevels;

		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<VirtualNestedListDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(10)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(11)] 
		[RED("classifier")] 
		public CHandle<VirutalNestedListClassifier> Classifier
		{
			get => GetProperty(ref _classifier);
			set => SetProperty(ref _classifier, value);
		}

		[Ordinal(12)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get => GetProperty(ref _defaultCollapsed);
			set => SetProperty(ref _defaultCollapsed, value);
		}

		[Ordinal(13)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get => GetProperty(ref _toggledLevels);
			set => SetProperty(ref _toggledLevels, value);
		}

		public VirtualNestedListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
