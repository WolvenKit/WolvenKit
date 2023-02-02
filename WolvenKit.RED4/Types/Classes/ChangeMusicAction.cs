using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeMusicAction : ActionBool
	{
		[Ordinal(25)] 
		[RED("interactionRecordName")] 
		public CString InteractionRecordName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(26)] 
		[RED("settings")] 
		public CHandle<MusicSettings> Settings
		{
			get => GetPropertyValue<CHandle<MusicSettings>>();
			set => SetPropertyValue<CHandle<MusicSettings>>(value);
		}

		public ChangeMusicAction()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			InteractionRecordName = "NextStation";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
