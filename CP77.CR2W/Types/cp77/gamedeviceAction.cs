using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedeviceAction : redEvent
	{
		[Ordinal(0)] [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)] [RED("clearanceLevel")] public CInt32 ClearanceLevel { get; set; }
		[Ordinal(2)] [RED("localizedObjectName")] public CString LocalizedObjectName { get; set; }

		public gamedeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
