using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class minimapuiSettings : CVariable
	{
		[Ordinal(0)] [RED("showTime")] public CFloat ShowTime { get; set; }
		[Ordinal(1)] [RED("hideTime")] public CFloat HideTime { get; set; }

		public minimapuiSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
