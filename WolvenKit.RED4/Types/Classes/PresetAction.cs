using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PresetAction : ActionBool
	{
		[Ordinal(39)] 
		[RED("preset")] 
		public CHandle<SmartHousePreset> Preset
		{
			get => GetPropertyValue<CHandle<SmartHousePreset>>();
			set => SetPropertyValue<CHandle<SmartHousePreset>>(value);
		}

		public PresetAction()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
