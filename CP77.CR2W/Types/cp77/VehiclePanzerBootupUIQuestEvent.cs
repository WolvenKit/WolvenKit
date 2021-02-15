using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehiclePanzerBootupUIQuestEvent : redEvent
	{
		[Ordinal(0)] [RED("mode")] public CEnum<panzerBootupUI> Mode { get; set; }

		public VehiclePanzerBootupUIQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
