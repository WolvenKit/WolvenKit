using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class drillMachineEvent : redEvent
	{
		[Ordinal(0)] [RED("newTargetDevice")] public wCHandle<gameObject> NewTargetDevice { get; set; }
		[Ordinal(1)] [RED("newIsActive")] public CBool NewIsActive { get; set; }

		public drillMachineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
