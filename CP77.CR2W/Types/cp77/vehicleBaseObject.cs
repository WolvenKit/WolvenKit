using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		[Ordinal(0)]  [RED("archetype")] public rRef<AIArchetype> Archetype { get; set; }
		[Ordinal(1)]  [RED("crowdMemberComponent")] public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
		[Ordinal(2)]  [RED("drivingTrafficPattern")] public CName DrivingTrafficPattern { get; set; }
		[Ordinal(3)]  [RED("hitTimestamp")] public CFloat HitTimestamp { get; set; }
		[Ordinal(4)]  [RED("inTrafficLane")] public CBool InTrafficLane { get; set; }
		[Ordinal(5)]  [RED("onPavement")] public CBool OnPavement { get; set; }
		[Ordinal(6)]  [RED("timesSentReactionEvent")] public CInt32 TimesSentReactionEvent { get; set; }
		[Ordinal(7)]  [RED("uiComponent")] public wCHandle<WorldWidgetComponent> UiComponent { get; set; }
		[Ordinal(8)]  [RED("vehicleComponent")] public wCHandle<VehicleComponent> VehicleComponent { get; set; }
		[Ordinal(9)]  [RED("vehicleUpsideDown")] public CBool VehicleUpsideDown { get; set; }

		public vehicleBaseObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
