using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVisualTagAppearanceMapping : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<audioVisualTagAppearanceGroup> Mappings
		{
			get => GetPropertyValue<CArray<audioVisualTagAppearanceGroup>>();
			set => SetPropertyValue<CArray<audioVisualTagAppearanceGroup>>(value);
		}

		public audioVisualTagAppearanceMapping()
		{
			Mappings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
