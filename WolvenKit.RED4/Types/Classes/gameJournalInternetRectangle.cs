
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetRectangle : gameJournalInternetBase
	{
		public gameJournalInternetRectangle()
		{
			TintColor = new CColor();
			HoverTintColor = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
