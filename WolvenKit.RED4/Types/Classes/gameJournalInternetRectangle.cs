
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetRectangle : gameJournalInternetBase
	{
		public gameJournalInternetRectangle()
		{
			TintColor = new CColor { Red = 255, Green = 255, Blue = 255 };
			HoverTintColor = new CColor { Red = 255, Green = 255, Blue = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
