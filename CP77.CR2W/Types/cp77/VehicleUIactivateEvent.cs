using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleUIactivateEvent : redEvent
	{
		[Ordinal(0)] [RED("activate")] public CBool Activate { get; set; }

		public VehicleUIactivateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
