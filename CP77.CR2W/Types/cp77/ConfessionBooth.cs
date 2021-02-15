using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ConfessionBooth : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(100)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public ConfessionBooth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
