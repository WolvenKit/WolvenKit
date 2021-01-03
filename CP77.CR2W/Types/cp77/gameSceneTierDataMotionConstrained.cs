using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		[Ordinal(0)]  [RED("adjustingDuration")] public CFloat AdjustingDuration { get; set; }
		[Ordinal(1)]  [RED("adjustingSpeed")] public CFloat AdjustingSpeed { get; set; }
		[Ordinal(2)]  [RED("notificationBackwardIndex")] public CInt32 NotificationBackwardIndex { get; set; }
		[Ordinal(3)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(4)]  [RED("travellingDuration")] public CFloat TravellingDuration { get; set; }
		[Ordinal(5)]  [RED("travellingSpeed")] public CFloat TravellingSpeed { get; set; }

		public gameSceneTierDataMotionConstrained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
