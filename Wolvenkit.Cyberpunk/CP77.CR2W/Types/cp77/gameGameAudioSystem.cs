using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameGameAudioSystem : gameIGameAudioSystem
	{
		[Ordinal(0)]  [RED("enemyPingStimCount")] public CUInt8 EnemyPingStimCount { get; set; }
		[Ordinal(1)]  [RED("mixHasDetectedCombat")] public CBool MixHasDetectedCombat { get; set; }

		public gameGameAudioSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
