using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleCollisionMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("minImpactVelocityThreshold")] public CFloat MinImpactVelocityThreshold { get; set; }
		[Ordinal(1)]  [RED("minRumbleVelocityThreshold")] public CFloat MinRumbleVelocityThreshold { get; set; }
		[Ordinal(2)]  [RED("rumbleCooldown")] public CFloat RumbleCooldown { get; set; }
		[Ordinal(3)]  [RED("scrapingMinTangentialVelocityThreshold")] public CFloat ScrapingMinTangentialVelocityThreshold { get; set; }
		[Ordinal(4)]  [RED("scrapingMaxCollisionCooldown")] public CFloat ScrapingMaxCollisionCooldown { get; set; }
		[Ordinal(5)]  [RED("scrapingMinVehicleUpCollisionContactAngle")] public CFloat ScrapingMinVehicleUpCollisionContactAngle { get; set; }
		[Ordinal(6)]  [RED("useScrapingMinVehicleUpCollisionContactAngle")] public CBool UseScrapingMinVehicleUpCollisionContactAngle { get; set; }
		[Ordinal(7)]  [RED("explosionEvent")] public CName ExplosionEvent { get; set; }
		[Ordinal(8)]  [RED("bigFireEvent")] public CName BigFireEvent { get; set; }
		[Ordinal(9)]  [RED("engineFireEvent")] public CName EngineFireEvent { get; set; }
		[Ordinal(10)]  [RED("coolerDamageEvent")] public CName CoolerDamageEvent { get; set; }
		[Ordinal(11)]  [RED("collisionSettings")] public CArray<audioVehicleCollisionMapItem> CollisionSettings { get; set; }

		public audioVehicleCollisionMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
