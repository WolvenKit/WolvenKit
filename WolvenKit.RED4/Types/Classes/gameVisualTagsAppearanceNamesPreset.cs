using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisualTagsAppearanceNamesPreset : ISerializable
	{
		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_Entity> Presets
		{
			get => GetPropertyValue<CArray<gameVisualTagsAppearanceNamesPreset_Entity>>();
			set => SetPropertyValue<CArray<gameVisualTagsAppearanceNamesPreset_Entity>>(value);
		}

		public gameVisualTagsAppearanceNamesPreset()
		{
			Presets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
