using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFullscreenCompositionResource : CResource
	{
		private CArray<inkCompositionPreset> _compositionPresets;
		private CHandle<inkCompositionPreviewSettings> _previewSettings;

		[Ordinal(1)] 
		[RED("compositionPresets")] 
		public CArray<inkCompositionPreset> CompositionPresets
		{
			get => GetProperty(ref _compositionPresets);
			set => SetProperty(ref _compositionPresets, value);
		}

		[Ordinal(2)] 
		[RED("previewSettings")] 
		public CHandle<inkCompositionPreviewSettings> PreviewSettings
		{
			get => GetProperty(ref _previewSettings);
			set => SetProperty(ref _previewSettings, value);
		}
	}
}
