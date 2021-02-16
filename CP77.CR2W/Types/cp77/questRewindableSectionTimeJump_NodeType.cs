using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRewindableSectionTimeJump_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("sceneFile")] public raRef<scnSceneResource> SceneFile { get; set; }
		[Ordinal(1)] [RED("jumpTargetTime")] public CUInt32 JumpTargetTime { get; set; }
		[Ordinal(2)] [RED("jumpSpeed")] public CFloat JumpSpeed { get; set; }
		[Ordinal(3)] [RED("postJumpPlayDirection")] public CEnum<scnPlayDirection> PostJumpPlayDirection { get; set; }
		[Ordinal(4)] [RED("postJumpPlaySpeed")] public CEnum<scnPlaySpeed> PostJumpPlaySpeed { get; set; }

		public questRewindableSectionTimeJump_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
