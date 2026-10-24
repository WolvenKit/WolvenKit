using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleOverrideForceBrakes : ActionBool
	{
		[Ordinal(39)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleOverrideForceBrakes()
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
