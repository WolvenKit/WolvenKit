using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CallElevator : ActionBool
	{
		[Ordinal(25)] 
		[RED("destination")] 
		public CInt32 Destination
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CallElevator()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
