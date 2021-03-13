using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorProximityDetector : ProximityDetector
	{
		[Ordinal(92)] [RED("debugIsBlinkOn")] public CBool DebugIsBlinkOn { get; set; }
		[Ordinal(93)] [RED("triggeredAlarmID")] public gameDelayID TriggeredAlarmID { get; set; }
		[Ordinal(94)] [RED("blinkInterval")] public CFloat BlinkInterval { get; set; }

		public DoorProximityDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
