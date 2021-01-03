using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAdvertSoundMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("audioEvent1")] public CName AudioEvent1 { get; set; }
		[Ordinal(1)]  [RED("audioEvent2")] public CName AudioEvent2 { get; set; }
		[Ordinal(2)]  [RED("audioEvent3")] public CName AudioEvent3 { get; set; }
		[Ordinal(3)]  [RED("audioEvent4")] public CName AudioEvent4 { get; set; }
		[Ordinal(4)]  [RED("soundDelay1")] public CFloat SoundDelay1 { get; set; }
		[Ordinal(5)]  [RED("soundDelay2")] public CFloat SoundDelay2 { get; set; }
		[Ordinal(6)]  [RED("soundDelay3")] public CFloat SoundDelay3 { get; set; }
		[Ordinal(7)]  [RED("soundDelay4")] public CFloat SoundDelay4 { get; set; }
		[Ordinal(8)]  [RED("speedOfSound")] public CFloat SpeedOfSound { get; set; }
		[Ordinal(9)]  [RED("useCustomDelays")] public CBool UseCustomDelays { get; set; }

		public audioAdvertSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
