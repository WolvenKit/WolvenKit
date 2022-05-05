using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyNPCAppearanceMappingMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fallbackMetadata")] 
		public CName FallbackMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("NPCsPerAppearance")] 
		public CArray<audioAppearanceToNPCMetadata> NPCsPerAppearance
		{
			get => GetPropertyValue<CArray<audioAppearanceToNPCMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToNPCMetadata>>(value);
		}

		[Ordinal(3)] 
		[RED("NPCsPerMainMaterial")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerMainMaterial
		{
			get => GetPropertyValue<CArray<audioVisualTagToNPCMetadata>>();
			set => SetPropertyValue<CArray<audioVisualTagToNPCMetadata>>(value);
		}

		[Ordinal(4)] 
		[RED("NPCsPerAdditive")] 
		public CArray<audioVisualTagToNPCMetadata> NPCsPerAdditive
		{
			get => GetPropertyValue<CArray<audioVisualTagToNPCMetadata>>();
			set => SetPropertyValue<CArray<audioVisualTagToNPCMetadata>>(value);
		}

		public audioFoleyNPCAppearanceMappingMetadata()
		{
			NPCsPerAppearance = new();
			NPCsPerMainMaterial = new();
			NPCsPerAdditive = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
