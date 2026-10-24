
namespace WolvenKit.RED4.Types
{
	public partial class PlayDeafeningMusic : ActionBool
	{
		public PlayDeafeningMusic()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
