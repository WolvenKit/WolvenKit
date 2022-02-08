using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFullscreenCompositionResource : CResource
	{
		[Ordinal(1)] 
		[RED("compositionPresets")] 
		public CArray<inkCompositionPreset> CompositionPresets
		{
			get => GetPropertyValue<CArray<inkCompositionPreset>>();
			set => SetPropertyValue<CArray<inkCompositionPreset>>(value);
		}

		[Ordinal(2)] 
		[RED("previewSettings")] 
		public CHandle<inkCompositionPreviewSettings> PreviewSettings
		{
			get => GetPropertyValue<CHandle<inkCompositionPreviewSettings>>();
			set => SetPropertyValue<CHandle<inkCompositionPreviewSettings>>(value);
		}

		public inkFullscreenCompositionResource()
		{
			CompositionPresets = new();
		}
	}
}
