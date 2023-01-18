using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestSpotTargetReference : ActionEntityReference
	{
		[Ordinal(25)] 
		[RED("ForcedTarget")] 
		public entEntityID ForcedTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public QuestSpotTargetReference()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			ForcedTarget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
