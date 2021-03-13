using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewCycleEvent : redEvent
	{
		[Ordinal(0)] [RED("cyclesCount")] public CUInt16 CyclesCount { get; set; }

		public NewCycleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
