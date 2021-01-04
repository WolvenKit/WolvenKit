using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VoiceOverQuickHackFeedbackEvent : redEvent
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("voName")] public CName VoName { get; set; }

		public VoiceOverQuickHackFeedbackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
