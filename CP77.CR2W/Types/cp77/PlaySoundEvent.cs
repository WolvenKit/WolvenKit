using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlaySoundEvent : MusicSettings
	{
		[Ordinal(1)] [RED("soundEvent")] public CName SoundEvent { get; set; }

		public PlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
