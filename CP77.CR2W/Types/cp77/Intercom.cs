using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Intercom : InteractiveDevice
	{
		[Ordinal(93)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(94)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(95)] [RED("distractionSound")] public CName DistractionSound { get; set; }

		public Intercom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
