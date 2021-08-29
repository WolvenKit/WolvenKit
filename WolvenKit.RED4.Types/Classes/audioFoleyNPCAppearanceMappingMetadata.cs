using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioFoleyNPCAppearanceMappingMetadata : audioAudioMetadata
	{
		private CName _fallbackMetadata;
		private CArray<audioAppearanceToNPCMetadata> _nPCsPerAppearance;
		private CArray<audioVisualTagToNPCMetadata> _nPCsPerMainMaterial;
		private CArray<audioVisualTagToNPCMetadata> _nPCsPerAdditive;

		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get => GetProperty(ref _fallbackMetadata);
			set => SetProperty(ref _fallbackMetadata, value);
		}

		[Ordinal(2)] 
		[RED("NPCsPerAppearance")] 
		public CArray<audioAppearanceToNPCMetadata> NPCsPerAppearance
		{
			get => GetProperty(ref _nPCsPerAppearance);
			set => SetProperty(ref _nPCsPerAppearance, value);
		}

		[Ordinal(3)] 
		[RED("NPCsPerMainMaterial")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerMainMaterial
		{
			get => GetProperty(ref _nPCsPerMainMaterial);
			set => SetProperty(ref _nPCsPerMainMaterial, value);
		}

		[Ordinal(4)] 
		[RED("NPCsPerAdditive")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerAdditive
		{
			get => GetProperty(ref _nPCsPerAdditive);
			set => SetProperty(ref _nPCsPerAdditive, value);
		}
	}
}
