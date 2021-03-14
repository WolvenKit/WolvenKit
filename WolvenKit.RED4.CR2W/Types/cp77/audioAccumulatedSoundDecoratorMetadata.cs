using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAccumulatedSoundDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("accumulatedSounds")] public CArray<CName> AccumulatedSounds { get; set; }
		[Ordinal(2)] [RED("inSpammingMode")] public CBool InSpammingMode { get; set; }
		[Ordinal(3)] [RED("fadeParam")] public CName FadeParam { get; set; }
		[Ordinal(4)] [RED("soundTimeout")] public CFloat SoundTimeout { get; set; }
		[Ordinal(5)] [RED("loopStart")] public CName LoopStart { get; set; }
		[Ordinal(6)] [RED("loopEnd")] public CName LoopEnd { get; set; }
		[Ordinal(7)] [RED("spammingSound")] public CName SpammingSound { get; set; }
		[Ordinal(8)] [RED("spammingSoundInterval")] public CFloat SpammingSoundInterval { get; set; }

		public audioAccumulatedSoundDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
