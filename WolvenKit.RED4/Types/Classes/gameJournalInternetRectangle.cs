
namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetRectangle : gameJournalInternetBase
	{
		public gameJournalInternetRectangle()
		{
			TintColor = new();
			HoverTintColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
