using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioEvent : redEvent
	{
		[Ordinal(0)] [RED("toggle")] public CBool Toggle { get; set; }
		[Ordinal(1)] [RED("setStation")] public CBool SetStation { get; set; }
		[Ordinal(2)] [RED("station")] public CInt32 Station { get; set; }

		public VehicleRadioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
