using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SensePresetChangeEvent : senseVisibilityEvent
	{
		private TweakDBID _presetID;
		private CBool _mainPreset;
		private CBool _reset;

		[Ordinal(4)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}

		[Ordinal(5)] 
		[RED("mainPreset")] 
		public CBool MainPreset
		{
			get => GetProperty(ref _mainPreset);
			set => SetProperty(ref _mainPreset, value);
		}

		[Ordinal(6)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}
	}
}
