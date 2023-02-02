using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionForceResetDevice : ActionBool
	{
		[Ordinal(25)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActionForceResetDevice()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			RestartDuration = 30;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
