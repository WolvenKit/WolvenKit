using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemFilterToggleController : ToggleController
	{
		[Ordinal(16)] 
		[RED("newItemDot")] 
		public inkWidgetReference NewItemDot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("useCategoryFilter")] 
		public CBool UseCategoryFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemFilterToggleController()
		{
			NewItemDot = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
