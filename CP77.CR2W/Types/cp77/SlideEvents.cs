using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlideEvents : CrouchEvents
	{
		[Ordinal(0)]  [RED("addDecelerationModifier")] public CHandle<gameStatModifierData> AddDecelerationModifier { get; set; }
		[Ordinal(1)]  [RED("rumblePlayed")] public CBool RumblePlayed { get; set; }

		public SlideEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
