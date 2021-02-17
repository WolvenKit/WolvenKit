using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AlarmLight : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("isGlitching")] public CBool IsGlitching { get; set; }

		public AlarmLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
