using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaySoundEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("soundEventName")] public CName SoundEventName { get; set; }

		public inkanimPlaySoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
