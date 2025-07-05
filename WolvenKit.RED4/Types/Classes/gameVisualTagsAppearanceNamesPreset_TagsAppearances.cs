using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
	{
		[Ordinal(0)] 
		[RED("visualTagHash")] 
		public CName VisualTagHash
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("appearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameVisualTagsAppearanceNamesPreset_TagsAppearances()
		{
			AppearanceNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
