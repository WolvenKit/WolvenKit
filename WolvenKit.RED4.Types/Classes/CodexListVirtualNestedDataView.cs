using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListVirtualNestedDataView : VirtualNestedListDataView
	{
		private CEnum<CodexCategoryType> _currentFilter;

		[Ordinal(3)] 
		[RED("currentFilter")] 
		public CEnum<CodexCategoryType> CurrentFilter
		{
			get => GetProperty(ref _currentFilter);
			set => SetProperty(ref _currentFilter, value);
		}
	}
}
