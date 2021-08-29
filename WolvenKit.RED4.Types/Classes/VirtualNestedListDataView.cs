using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualNestedListDataView : inkScriptableDataViewWrapper
	{
		private CHandle<CompareBuilder> _compareBuilder;
		private CBool _defaultCollapsed;
		private CArray<CInt32> _toggledLevels;

		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}

		[Ordinal(1)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get => GetProperty(ref _defaultCollapsed);
			set => SetProperty(ref _defaultCollapsed, value);
		}

		[Ordinal(2)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get => GetProperty(ref _toggledLevels);
			set => SetProperty(ref _toggledLevels, value);
		}
	}
}
