using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLipsyncMapping : CResource
	{
		private CName _languageCodeName;
		private CArray<CUInt64> _scenePaths;
		private CArray<animLipsyncMappingSceneEntry> _sceneEntries;

		[Ordinal(1)] 
		[RED("languageCodeName")] 
		public CName LanguageCodeName
		{
			get => GetProperty(ref _languageCodeName);
			set => SetProperty(ref _languageCodeName, value);
		}

		[Ordinal(2)] 
		[RED("scenePaths")] 
		public CArray<CUInt64> ScenePaths
		{
			get => GetProperty(ref _scenePaths);
			set => SetProperty(ref _scenePaths, value);
		}

		[Ordinal(4)] 
		[RED("sceneEntries")] 
		public CArray<animLipsyncMappingSceneEntry> SceneEntries
		{
			get => GetProperty(ref _sceneEntries);
			set => SetProperty(ref _sceneEntries, value);
		}
	}
}
