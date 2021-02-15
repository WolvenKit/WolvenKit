using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entFootPlantedEvent : redEvent
	{
		[Ordinal(0)] [RED("customAction")] public CName CustomAction { get; set; }
		[Ordinal(1)] [RED("footSide")] public CEnum<animEventSide> FootSide { get; set; }

		public entFootPlantedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
