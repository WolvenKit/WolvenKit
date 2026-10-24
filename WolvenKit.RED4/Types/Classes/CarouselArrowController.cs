using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarouselArrowController : PaginationArrowController
	{
		[Ordinal(2)] 
		[RED("bIsLeftArrow")] 
		public CBool BIsLeftArrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("modDetailsItem")] 
		public CWeakHandle<ModDetailsItem> ModDetailsItem
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		public CarouselArrowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
