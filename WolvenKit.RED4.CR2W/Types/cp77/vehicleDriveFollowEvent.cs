using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowEvent : redEvent
	{
		[Ordinal(0)] [RED("targetObjToFollow")] public wCHandle<gameObject> TargetObjToFollow { get; set; }
		[Ordinal(1)] [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(2)] [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(3)] [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(4)] [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public vehicleDriveFollowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
