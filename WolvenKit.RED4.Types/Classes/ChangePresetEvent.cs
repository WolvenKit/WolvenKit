using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangePresetEvent : redEvent
	{
		private CEnum<ESmartHousePreset> _presetID;

		[Ordinal(0)] 
		[RED("presetID")] 
		public CEnum<ESmartHousePreset> PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}
	}
}
