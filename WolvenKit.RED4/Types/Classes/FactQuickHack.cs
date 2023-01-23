using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactQuickHack : ActionBool
	{
		[Ordinal(25)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		public FactQuickHack()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			FactProperties = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
