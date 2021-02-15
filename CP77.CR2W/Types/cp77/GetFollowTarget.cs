using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GetFollowTarget : FollowVehicleTask
	{
		[Ordinal(0)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(2)] [RED("lastTime")] public CFloat LastTime { get; set; }
		[Ordinal(3)] [RED("timeout")] public CFloat Timeout { get; set; }
		[Ordinal(4)] [RED("timeoutDuration")] public CFloat TimeoutDuration { get; set; }

		public GetFollowTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
