using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceRewinding_ConditionType : scnIBraindanceConditionType
	{
		[Ordinal(0)]  [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(1)]  [RED("speed")] public CEnum<scnBraindanceSpeed> Speed { get; set; }

		public scnBraindanceRewinding_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
