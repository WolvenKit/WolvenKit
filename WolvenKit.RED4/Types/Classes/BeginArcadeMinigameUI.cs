
namespace WolvenKit.RED4.Types
{
	public partial class BeginArcadeMinigameUI : ActionBool
	{
		public BeginArcadeMinigameUI()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			Duration = 3.967000F;
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
