using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnVoicesetComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("blockedInputs")] public CArray<entVoicesetInputToBlock> BlockedInputs { get; set; }
		[Ordinal(1)]  [RED("voiceTag")] public CName VoiceTag { get; set; }
		[Ordinal(2)]  [RED("NPCHighLevelState")] public CEnum<gamedataNPCHighLevelState> NPCHighLevelState { get; set; }
		[Ordinal(3)]  [RED("gruntSetIndex")] public CUInt32 GruntSetIndex { get; set; }
		[Ordinal(4)]  [RED("areVoicesetLinesEnabled")] public CBool AreVoicesetLinesEnabled { get; set; }
		[Ordinal(5)]  [RED("areVoicesetGruntsEnabled")] public CBool AreVoicesetGruntsEnabled { get; set; }

		public scnVoicesetComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
