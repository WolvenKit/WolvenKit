using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSyncMethodLocomotion : animISyncMethod
	{
		[Ordinal(0)]  [RED("accelStopTimeEvent")] public CName AccelStopTimeEvent { get; set; }
		[Ordinal(1)]  [RED("locomotionFeatureName")] public CName LocomotionFeatureName { get; set; }

		public animSyncMethodLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
