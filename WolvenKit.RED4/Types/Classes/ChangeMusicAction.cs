using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeMusicAction : ActionBool
	{
		[Ordinal(38)] 
		[RED("interactionRecordName")] 
		public CString InteractionRecordName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(39)] 
		[RED("settings")] 
		public CHandle<MusicSettings> Settings
		{
			get => GetPropertyValue<CHandle<MusicSettings>>();
			set => SetPropertyValue<CHandle<MusicSettings>>(value);
		}

		public ChangeMusicAction()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			InteractionRecordName = "NextStation";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
