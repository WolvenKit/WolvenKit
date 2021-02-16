using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		[Ordinal(40)] [RED("archetype")] public rRef<AIArchetype> Archetype { get; set; }
		[Ordinal(41)] [RED("vehicleComponent")] public wCHandle<VehicleComponent> VehicleComponent { get; set; }
		[Ordinal(42)] [RED("uiComponent")] public wCHandle<WorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(43)] [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(44)] [RED("hitTimestamp")] public CFloat HitTimestamp { get; set; }
		[Ordinal(45)] [RED("drivingTrafficPattern")] public CName DrivingTrafficPattern { get; set; }
		[Ordinal(46)] [RED("onPavement")] public CBool OnPavement { get; set; }
		[Ordinal(47)] [RED("inTrafficLane")] public CBool InTrafficLane { get; set; }
		[Ordinal(48)] [RED("timesSentReactionEvent")] public CInt32 TimesSentReactionEvent { get; set; }
		[Ordinal(49)] [RED("vehicleUpsideDown")] public CBool VehicleUpsideDown { get; set; }

		public vehicleBaseObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
