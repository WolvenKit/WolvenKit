using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetExposeQuickHacks : ActionBool
	{
		[Ordinal(25)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetExposeQuickHacks()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			IsRemote = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
