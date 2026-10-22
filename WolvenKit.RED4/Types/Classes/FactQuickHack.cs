using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactQuickHack : ActionBool
	{
		[Ordinal(39)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		public FactQuickHack()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			FactProperties = new ComputerQuickHackData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
