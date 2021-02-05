using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSyncMethodLocomotion : animISyncMethod
	{
		[Ordinal(0)]  [RED("locomotionFeatureName")] public CName LocomotionFeatureName { get; set; }
		[Ordinal(1)]  [RED("accelStopTimeEvent")] public CName AccelStopTimeEvent { get; set; }

		public animSyncMethodLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
