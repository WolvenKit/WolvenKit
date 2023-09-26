
namespace WolvenKit.RED4.Types
{
	public partial class BeginArcadeMinigameUI : ActionBool
	{
		public BeginArcadeMinigameUI()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			Duration = 3.967000F;
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
