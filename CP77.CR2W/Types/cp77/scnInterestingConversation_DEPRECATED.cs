using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversation_DEPRECATED : CVariable
	{
		[Ordinal(0)] [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }

		public scnInterestingConversation_DEPRECATED(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
