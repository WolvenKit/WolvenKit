using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnDebugSymbols : CVariable
	{
		[Ordinal(0)]  [RED("performersDebugSymbols")] public CArray<scnPerformerSymbol> PerformersDebugSymbols { get; set; }
		[Ordinal(1)]  [RED("sceneEventsDebugSymbols")] public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols { get; set; }
		[Ordinal(2)]  [RED("sceneNodesDebugSymbols")] public CArray<scnNodeSymbol> SceneNodesDebugSymbols { get; set; }
		[Ordinal(3)]  [RED("workspotsDebugSymbols")] public CArray<scnWorkspotSymbol> WorkspotsDebugSymbols { get; set; }

		public scnDebugSymbols(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
