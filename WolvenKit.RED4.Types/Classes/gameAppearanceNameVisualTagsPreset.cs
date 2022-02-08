using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAppearanceNameVisualTagsPreset : ISerializable
	{
		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<gameAppearanceNameVisualTagsPreset_Entity> Presets
		{
			get => GetPropertyValue<CArray<gameAppearanceNameVisualTagsPreset_Entity>>();
			set => SetPropertyValue<CArray<gameAppearanceNameVisualTagsPreset_Entity>>(value);
		}

		public gameAppearanceNameVisualTagsPreset()
		{
			Presets = new();
		}
	}
}
