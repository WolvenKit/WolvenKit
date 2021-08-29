using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemFilterToggleController : ToggleController
	{
		private inkWidgetReference _newItemDot;
		private CBool _useCategoryFilter;

		[Ordinal(16)] 
		[RED("newItemDot")] 
		public inkWidgetReference NewItemDot
		{
			get => GetProperty(ref _newItemDot);
			set => SetProperty(ref _newItemDot, value);
		}

		[Ordinal(17)] 
		[RED("useCategoryFilter")] 
		public CBool UseCategoryFilter
		{
			get => GetProperty(ref _useCategoryFilter);
			set => SetProperty(ref _useCategoryFilter, value);
		}
	}
}
