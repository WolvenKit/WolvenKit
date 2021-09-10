using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListVirtualNestedDataView : VirtualNestedListDataView
	{
		[Ordinal(3)] 
		[RED("currentFilter")] 
		public CEnum<CodexCategoryType> CurrentFilter
		{
			get => GetPropertyValue<CEnum<CodexCategoryType>>();
			set => SetPropertyValue<CEnum<CodexCategoryType>>(value);
		}
	}
}
