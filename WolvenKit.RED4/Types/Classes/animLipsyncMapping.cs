using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLipsyncMapping : CResource
	{
		[Ordinal(1)] 
		[RED("languageCodeName")] 
		public CName LanguageCodeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("scenePaths")] 
		public CArray<CUInt64> ScenePaths
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(4)] 
		[RED("sceneEntries")] 
		public CArray<animLipsyncMappingSceneEntry> SceneEntries
		{
			get => GetPropertyValue<CArray<animLipsyncMappingSceneEntry>>();
			set => SetPropertyValue<CArray<animLipsyncMappingSceneEntry>>(value);
		}

		public animLipsyncMapping()
		{
			ScenePaths = new();
			SceneEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
