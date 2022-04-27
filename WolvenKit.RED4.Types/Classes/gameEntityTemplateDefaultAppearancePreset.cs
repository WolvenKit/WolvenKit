using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntityTemplateDefaultAppearancePreset : ISerializable
	{
		[Ordinal(0)] 
		[RED("defaultAppearancePresets")] 
		public CArray<gameDefaultAppearancePreset_Entity> DefaultAppearancePresets
		{
			get => GetPropertyValue<CArray<gameDefaultAppearancePreset_Entity>>();
			set => SetPropertyValue<CArray<gameDefaultAppearancePreset_Entity>>(value);
		}

		public gameEntityTemplateDefaultAppearancePreset()
		{
			DefaultAppearancePresets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
