using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleGlassTint : ActionBool
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

		public ToggleGlassTint()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			TrueRecord = "TintGlass";
			FalseRecord = "ClearGlass";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
