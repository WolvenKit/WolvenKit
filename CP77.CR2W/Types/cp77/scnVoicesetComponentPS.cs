using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnVoicesetComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("NPCHighLevelState")] public CEnum<gamedataNPCHighLevelState> NPCHighLevelState { get; set; }
		[Ordinal(1)]  [RED("areVoicesetGruntsEnabled")] public CBool AreVoicesetGruntsEnabled { get; set; }
		[Ordinal(2)]  [RED("areVoicesetLinesEnabled")] public CBool AreVoicesetLinesEnabled { get; set; }
		[Ordinal(3)]  [RED("blockedInputs")] public CArray<entVoicesetInputToBlock> BlockedInputs { get; set; }
		[Ordinal(4)]  [RED("gruntSetIndex")] public CUInt32 GruntSetIndex { get; set; }
		[Ordinal(5)]  [RED("voiceTag")] public CName VoiceTag { get; set; }

		public scnVoicesetComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
