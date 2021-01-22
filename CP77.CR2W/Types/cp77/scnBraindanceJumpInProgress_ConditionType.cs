using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceJumpInProgress_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)]  [RED("inProgress")] public CBool InProgress { get; set; }
		[Ordinal(1)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public scnBraindanceJumpInProgress_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
