using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FullSystemRestart : ActionBool
	{
		[Ordinal(39)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public FullSystemRestart()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			RestartDuration = 10;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
