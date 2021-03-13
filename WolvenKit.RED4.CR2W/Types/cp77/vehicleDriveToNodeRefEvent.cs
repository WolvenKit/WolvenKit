using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToNodeRefEvent : redEvent
	{
		[Ordinal(0)] [RED("targetRef")] public NodeRef TargetRef { get; set; }
		[Ordinal(1)] [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(2)] [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }

		public vehicleDriveToNodeRefEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
