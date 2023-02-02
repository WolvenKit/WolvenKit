
namespace WolvenKit.RED4.Types
{
	public partial class QuickHackToggleOpen : ActionBool
	{
		public QuickHackToggleOpen()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			IsQuickHack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
