using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PresetAction : ActionBool
	{
		[Ordinal(38)] 
		[RED("preset")] 
		public CHandle<SmartHousePreset> Preset
		{
			get => GetPropertyValue<CHandle<SmartHousePreset>>();
			set => SetPropertyValue<CHandle<SmartHousePreset>>(value);
		}

		public PresetAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
