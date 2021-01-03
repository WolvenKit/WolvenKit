using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GetFollowTarget : FollowVehicleTask
	{
		[Ordinal(0)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("lastTime")] public CFloat LastTime { get; set; }
		[Ordinal(2)]  [RED("timeout")] public CFloat Timeout { get; set; }
		[Ordinal(3)]  [RED("timeoutDuration")] public CFloat TimeoutDuration { get; set; }
		[Ordinal(4)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public GetFollowTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
