using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityTemplateDefaultAppearancePreset : ISerializable
	{
		private CArray<gameDefaultAppearancePreset_Entity> _defaultAppearancePresets;

		[Ordinal(0)] 
		[RED("defaultAppearancePresets")] 
		public CArray<gameDefaultAppearancePreset_Entity> DefaultAppearancePresets
		{
			get => GetProperty(ref _defaultAppearancePresets);
			set => SetProperty(ref _defaultAppearancePresets, value);
		}
	}
}
