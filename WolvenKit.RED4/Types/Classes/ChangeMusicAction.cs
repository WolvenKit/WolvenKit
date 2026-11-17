using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeMusicAction : ActionBool
	{
		[Ordinal(39)] 
		[RED("interactionRecordName")] 
		public CString InteractionRecordName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(40)] 
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
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			InteractionRecordName = "NextStation";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
