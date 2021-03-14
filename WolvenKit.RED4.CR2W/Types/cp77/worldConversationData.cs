using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldConversationData : ISerializable
	{
		[Ordinal(0)] [RED("sceneFilename")] public raRef<scnSceneResource> SceneFilename { get; set; }
		[Ordinal(1)] [RED("condition")] public CHandle<questIBaseCondition> Condition { get; set; }
		[Ordinal(2)] [RED("interruptionOperations")] public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations { get; set; }
		[Ordinal(3)] [RED("ignoreLocalLimit")] public CBool IgnoreLocalLimit { get; set; }
		[Ordinal(4)] [RED("ignoreGlobalLimit")] public CBool IgnoreGlobalLimit { get; set; }

		public worldConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
