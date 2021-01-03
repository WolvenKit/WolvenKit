using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameGameAudioSystem : gameIGameAudioSystem
	{
		[Ordinal(0)]  [RED("enemyPingStimCount")] public CUInt8 EnemyPingStimCount { get; set; }
		[Ordinal(1)]  [RED("mixHasDetectedCombat")] public CBool MixHasDetectedCombat { get; set; }

		public gameGameAudioSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
