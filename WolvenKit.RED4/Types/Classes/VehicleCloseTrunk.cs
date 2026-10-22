
namespace WolvenKit.RED4.Types
{
	public partial class VehicleCloseTrunk : ActionBool
	{
		public VehicleCloseTrunk()
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
