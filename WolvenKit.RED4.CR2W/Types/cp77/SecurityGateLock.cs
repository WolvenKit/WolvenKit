using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLock : InteractiveDevice
	{
		[Ordinal(93)] [RED("enteringArea")] public CHandle<gameStaticTriggerAreaComponent> EnteringArea { get; set; }
		[Ordinal(94)] [RED("centeredArea")] public CHandle<gameStaticTriggerAreaComponent> CenteredArea { get; set; }
		[Ordinal(95)] [RED("leavingArea")] public CHandle<gameStaticTriggerAreaComponent> LeavingArea { get; set; }

		public SecurityGateLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
