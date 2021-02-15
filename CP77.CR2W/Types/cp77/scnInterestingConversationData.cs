using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationData : ISerializable
	{
		[Ordinal(0)] [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }
		[Ordinal(1)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }

		public scnInterestingConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
