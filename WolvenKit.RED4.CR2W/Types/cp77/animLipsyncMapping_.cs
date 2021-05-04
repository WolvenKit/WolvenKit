using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMapping_ : CResource
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

		public animLipsyncMapping_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
