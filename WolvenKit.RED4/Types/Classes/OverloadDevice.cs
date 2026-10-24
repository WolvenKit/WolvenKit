using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverloadDevice : ActionBool
	{
		[Ordinal(39)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OverloadDevice()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			KillDelay = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
