using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsSceneChanges : CVariable
	{
		[Ordinal(0)] [RED("scene")] public raRef<scnSceneResource> Scene { get; set; }
		[Ordinal(1)] [RED("sceneChanges")] public CArray<scnScenesVersionsChangedRecord> SceneChanges { get; set; }

		public scnScenesVersionsSceneChanges(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
