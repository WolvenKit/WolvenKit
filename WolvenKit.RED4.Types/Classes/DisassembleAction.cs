
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassembleAction : BaseItemAction
	{

		public DisassembleAction()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			Quantity = 1;
		}
	}
}
