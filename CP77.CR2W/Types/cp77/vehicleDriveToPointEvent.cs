using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToPointEvent : redEvent
	{
		[Ordinal(0)]  [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(1)]  [RED("targetPos")] public Vector3 TargetPos { get; set; }
		[Ordinal(2)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public vehicleDriveToPointEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
