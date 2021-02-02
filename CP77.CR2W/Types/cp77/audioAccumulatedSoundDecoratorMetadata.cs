using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAccumulatedSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("accumulatedSounds")] public CArray<CName> AccumulatedSounds { get; set; }
		[Ordinal(1)]  [RED("loopStart")] public CName LoopStart { get; set; }
		[Ordinal(2)]  [RED("loopEnd")] public CName LoopEnd { get; set; }
		[Ordinal(3)]  [RED("fadeParam")] public CName FadeParam { get; set; }
		[Ordinal(4)]  [RED("soundTimeout")] public CFloat SoundTimeout { get; set; }
		[Ordinal(5)]  [RED("inSpammingMode")] public CBool InSpammingMode { get; set; }
		[Ordinal(6)]  [RED("spammingSound")] public CName SpammingSound { get; set; }
		[Ordinal(7)]  [RED("spammingSoundInterval")] public CFloat SpammingSoundInterval { get; set; }

		public audioAccumulatedSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
