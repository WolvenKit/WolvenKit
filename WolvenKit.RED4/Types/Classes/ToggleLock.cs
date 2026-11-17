using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleLock : ActionBool
	{
		[Ordinal(39)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleLock()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ShouldOpen = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
