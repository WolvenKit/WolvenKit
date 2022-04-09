using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerUnauthorized : ActionBool
	{
		[Ordinal(25)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerUnauthorized()
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
