using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestWindowDestructionEvent : redEvent
	{
		[Ordinal(0)]  [RED("window")] public CEnum<vehicleQuestWindowDestruction> Window { get; set; }
		[Ordinal(1)]  [RED("windowName")] public CName WindowName { get; set; }

		public VehicleQuestWindowDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
