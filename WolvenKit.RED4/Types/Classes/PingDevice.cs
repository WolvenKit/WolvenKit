using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingDevice : ActionBool
	{
		[Ordinal(39)] 
		[RED("shouldForward")] 
		public CBool ShouldForward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PingDevice()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ShouldForward = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
