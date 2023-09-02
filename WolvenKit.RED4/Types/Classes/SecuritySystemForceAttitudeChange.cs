using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemForceAttitudeChange : ScriptableDeviceAction
	{
		[Ordinal(25)] 
		[RED("newAttitude")] 
		public CName NewAttitude
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecuritySystemForceAttitudeChange()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
