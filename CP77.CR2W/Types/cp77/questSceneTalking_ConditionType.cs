using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSceneTalking_ConditionType : questISceneConditionType
	{
		[Ordinal(0)] [RED("GlobalEntityRef")] public gameEntityReference GlobalEntityRef { get; set; }
		[Ordinal(1)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(2)] [RED("SectionName")] public CName SectionName { get; set; }
		[Ordinal(3)] [RED("ActorName")] public CString ActorName { get; set; }
		[Ordinal(4)] [RED("isInverted")] public CBool IsInverted { get; set; }

		public questSceneTalking_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
