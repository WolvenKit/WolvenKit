using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PresetAction : ActionBool
	{
		[Ordinal(25)] 
		[RED("preset")] 
		public CHandle<SmartHousePreset> Preset
		{
			get => GetPropertyValue<CHandle<SmartHousePreset>>();
			set => SetPropertyValue<CHandle<SmartHousePreset>>(value);
		}

		public PresetAction()
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
