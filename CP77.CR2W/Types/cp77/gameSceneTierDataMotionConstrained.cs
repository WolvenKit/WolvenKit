using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		[Ordinal(2)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(3)] [RED("adjustingSpeed")] public CFloat AdjustingSpeed { get; set; }
		[Ordinal(4)] [RED("adjustingDuration")] public CFloat AdjustingDuration { get; set; }
		[Ordinal(5)] [RED("travellingSpeed")] public CFloat TravellingSpeed { get; set; }
		[Ordinal(6)] [RED("travellingDuration")] public CFloat TravellingDuration { get; set; }
		[Ordinal(7)] [RED("notificationBackwardIndex")] public CInt32 NotificationBackwardIndex { get; set; }

		public gameSceneTierDataMotionConstrained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
