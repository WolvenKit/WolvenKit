using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSceneTalking_ConditionType : questISceneConditionType
	{
		[Ordinal(0)]  [RED("ActorName")] public CString ActorName { get; set; }
		[Ordinal(1)]  [RED("GlobalEntityRef")] public gameEntityReference GlobalEntityRef { get; set; }
		[Ordinal(2)]  [RED("SectionName")] public CName SectionName { get; set; }
		[Ordinal(3)]  [RED("isInverted")] public CBool IsInverted { get; set; }
		[Ordinal(4)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public questSceneTalking_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
