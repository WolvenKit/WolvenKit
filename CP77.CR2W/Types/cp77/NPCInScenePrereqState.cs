using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCInScenePrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("sceneListener")] public CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> SceneListener { get; set; }

		public NPCInScenePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
