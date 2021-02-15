using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entInjectVoiceTagEvent : redEvent
	{
		[Ordinal(0)] [RED("voiceTagName")] public CName VoiceTagName { get; set; }
		[Ordinal(1)] [RED("forceInjection")] public CBool ForceInjection { get; set; }

		public entInjectVoiceTagEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
