using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsPlaySound : redEvent
	{
		[Ordinal(0)]  [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(1)]  [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(2)]  [RED("playUnique")] public CBool PlayUnique { get; set; }
		[Ordinal(3)]  [RED("seekTime")] public CFloat SeekTime { get; set; }
		[Ordinal(4)]  [RED("soundName")] public CName SoundName { get; set; }

		public gameaudioeventsPlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
