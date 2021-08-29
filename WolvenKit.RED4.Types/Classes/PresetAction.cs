using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PresetAction : ActionBool
	{
		private CHandle<SmartHousePreset> _preset;

		[Ordinal(25)] 
		[RED("preset")] 
		public CHandle<SmartHousePreset> Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}
	}
}
