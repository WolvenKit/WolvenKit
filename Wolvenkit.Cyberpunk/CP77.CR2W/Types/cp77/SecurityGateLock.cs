using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLock : InteractiveDevice
	{
		[Ordinal(0)]  [RED("centeredArea")] public CHandle<gameStaticTriggerAreaComponent> CenteredArea { get; set; }
		[Ordinal(1)]  [RED("enteringArea")] public CHandle<gameStaticTriggerAreaComponent> EnteringArea { get; set; }
		[Ordinal(2)]  [RED("leavingArea")] public CHandle<gameStaticTriggerAreaComponent> LeavingArea { get; set; }

		public SecurityGateLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
