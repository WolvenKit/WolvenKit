using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		[Ordinal(31)]  [RED("archetype")] public rRef<AIArchetype> Archetype { get; set; }
		[Ordinal(32)]  [RED("vehicleComponent")] public wCHandle<VehicleComponent> VehicleComponent { get; set; }
		[Ordinal(33)]  [RED("uiComponent")] public wCHandle<WorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(34)]  [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(35)]  [RED("hitTimestamp")] public CFloat HitTimestamp { get; set; }
		[Ordinal(36)]  [RED("drivingTrafficPattern")] public CName DrivingTrafficPattern { get; set; }
		[Ordinal(37)]  [RED("onPavement")] public CBool OnPavement { get; set; }
		[Ordinal(38)]  [RED("inTrafficLane")] public CBool InTrafficLane { get; set; }
		[Ordinal(39)]  [RED("timesSentReactionEvent")] public CInt32 TimesSentReactionEvent { get; set; }
		[Ordinal(40)]  [RED("vehicleUpsideDown")] public CBool VehicleUpsideDown { get; set; }

		public vehicleBaseObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
