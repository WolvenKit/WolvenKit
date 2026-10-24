using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionForceResetDevice : ActionBool
	{
		[Ordinal(39)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActionForceResetDevice()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			RestartDuration = 30;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
