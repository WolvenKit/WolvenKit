using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneEventSymbol : CVariable
	{
		[Ordinal(0)]  [RED("editorEventId")] public CUInt64 EditorEventId { get; set; }
		[Ordinal(1)]  [RED("originNodeId")] public scnNodeId OriginNodeId { get; set; }
		[Ordinal(2)]  [RED("sceneEventIds")] public CArray<scnSceneEventId> SceneEventIds { get; set; }

		public scnSceneEventSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
