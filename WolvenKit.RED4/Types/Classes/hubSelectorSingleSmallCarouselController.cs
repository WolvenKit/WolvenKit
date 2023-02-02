
namespace WolvenKit.RED4.Types
{
	public partial class hubSelectorSingleSmallCarouselController : hubSelectorSingleCarouselController
	{
		public hubSelectorSingleSmallCarouselController()
		{
			NUMBER_OF_WIDGETS = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
