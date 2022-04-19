using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpiderbotBoolAction : ActionBool
	{
		[Ordinal(25)] 
		[RED("TrueRecord")] 
		public CString TrueRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(26)] 
		[RED("FalseRecord")] 
		public CString FalseRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SpiderbotBoolAction()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			TrueRecord = "SpiderbotToggleOn";
			FalseRecord = "SpiderbotToggleOff";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
