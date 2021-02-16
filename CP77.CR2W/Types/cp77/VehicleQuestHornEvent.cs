using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestHornEvent : redEvent
	{
		[Ordinal(0)] [RED("honkTime")] public CFloat HonkTime { get; set; }

		public VehicleQuestHornEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
