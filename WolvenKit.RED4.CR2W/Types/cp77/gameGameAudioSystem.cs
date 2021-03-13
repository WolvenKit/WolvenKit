using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGameAudioSystem : gameIGameAudioSystem
	{
		[Ordinal(0)] [RED("enemyPingStimCount")] public CUInt8 EnemyPingStimCount { get; set; }
		[Ordinal(1)] [RED("mixHasDetectedCombat")] public CBool MixHasDetectedCombat { get; set; }

		public gameGameAudioSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
