using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceLayer_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)] [RED("layer")] public CEnum<scnBraindanceLayer> Layer { get; set; }
		[Ordinal(1)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }

		public scnBraindanceLayer_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
