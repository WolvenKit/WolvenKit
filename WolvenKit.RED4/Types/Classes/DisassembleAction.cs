
namespace WolvenKit.RED4.Types
{
	public partial class DisassembleAction : BaseItemAction
	{
		public DisassembleAction()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			Quantity = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
