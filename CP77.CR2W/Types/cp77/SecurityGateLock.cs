using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
