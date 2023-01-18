
namespace WolvenKit.RED4.Types
{
	public partial class EquipAction : BaseItemAction
	{
		public EquipAction()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			Quantity = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
