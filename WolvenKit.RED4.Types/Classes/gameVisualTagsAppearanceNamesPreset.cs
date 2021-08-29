using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisualTagsAppearanceNamesPreset : ISerializable
	{
		private CArray<gameVisualTagsAppearanceNamesPreset_Entity> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<gameVisualTagsAppearanceNamesPreset_Entity> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}
	}
}
