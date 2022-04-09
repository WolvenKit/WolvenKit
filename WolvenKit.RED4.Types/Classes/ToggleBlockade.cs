using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleBlockade : ActionBool
	{
		[Ordinal(25)] 
		[RED("TrueRecordName")] 
		public CString TrueRecordName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(26)] 
		[RED("FalseRecordName")] 
		public CString FalseRecordName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ToggleBlockade()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			TrueRecordName = "Raise";
			FalseRecordName = "Lower";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
