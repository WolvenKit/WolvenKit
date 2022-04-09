
namespace WolvenKit.RED4.Types
{
	public partial class ToggleTiltBlinders : ActionBool
	{
		public ToggleTiltBlinders()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
