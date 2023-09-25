using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemFilterToggleController : ToggleController
	{
		[Ordinal(19)] 
		[RED("newItemDot")] 
		public inkWidgetReference NewItemDot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("useCategoryFilter")] 
		public CBool UseCategoryFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemFilterToggleController()
		{
			NewItemDot = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
