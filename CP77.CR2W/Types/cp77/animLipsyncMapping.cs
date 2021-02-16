using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLipsyncMapping : CResource
	{
		[Ordinal(1)] [RED("languageCodeName")] public CName LanguageCodeName { get; set; }
		[Ordinal(2)] [RED("scenePaths")] public CArray<CUInt64> ScenePaths { get; set; }
		[Ordinal(3)] [RED("sceneEntries")] public CArray<animLipsyncMappingSceneEntry> SceneEntries { get; set; }

		public animLipsyncMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
