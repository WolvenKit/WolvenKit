using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangePresetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("presetID")] 
		public CEnum<ESmartHousePreset> PresetID
		{
			get => GetPropertyValue<CEnum<ESmartHousePreset>>();
			set => SetPropertyValue<CEnum<ESmartHousePreset>>(value);
		}

		public ChangePresetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
