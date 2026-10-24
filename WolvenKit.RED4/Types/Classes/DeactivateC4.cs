using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeactivateC4 : ActionBool
	{
		[Ordinal(39)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public DeactivateC4()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
