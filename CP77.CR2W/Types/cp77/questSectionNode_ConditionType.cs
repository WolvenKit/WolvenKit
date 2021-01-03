using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSectionNode_ConditionType : questISceneConditionType
	{
		[Ordinal(0)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(1)]  [RED("sectionName")] public CName SectionName { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<questSceneConditionType> Type { get; set; }

		public questSectionNode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
