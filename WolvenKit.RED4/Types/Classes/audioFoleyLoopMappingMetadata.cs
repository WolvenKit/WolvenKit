using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyLoopMappingMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("loopsPerAppearance")] 
		public CArray<audioAppearanceToFoleyLoopMetadata> LoopsPerAppearance
		{
			get => GetPropertyValue<CArray<audioAppearanceToFoleyLoopMetadata>>();
			set => SetPropertyValue<CArray<audioAppearanceToFoleyLoopMetadata>>(value);
		}

		[Ordinal(2)] 
		[RED("loopsPerVisualTag")] 
		public CArray<audioVisualTagToFoleyLoopMetadata> LoopsPerVisualTag
		{
			get => GetPropertyValue<CArray<audioVisualTagToFoleyLoopMetadata>>();
			set => SetPropertyValue<CArray<audioVisualTagToFoleyLoopMetadata>>(value);
		}

		public audioFoleyLoopMappingMetadata()
		{
			LoopsPerAppearance = new();
			LoopsPerVisualTag = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
