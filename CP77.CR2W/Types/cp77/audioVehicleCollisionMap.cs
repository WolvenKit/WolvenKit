using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehicleCollisionMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bigFireEvent")] public CName BigFireEvent { get; set; }
		[Ordinal(1)]  [RED("collisionSettings")] public CArray<audioVehicleCollisionMapItem> CollisionSettings { get; set; }
		[Ordinal(2)]  [RED("coolerDamageEvent")] public CName CoolerDamageEvent { get; set; }
		[Ordinal(3)]  [RED("engineFireEvent")] public CName EngineFireEvent { get; set; }
		[Ordinal(4)]  [RED("explosionEvent")] public CName ExplosionEvent { get; set; }
		[Ordinal(5)]  [RED("minImpactVelocityThreshold")] public CFloat MinImpactVelocityThreshold { get; set; }
		[Ordinal(6)]  [RED("minRumbleVelocityThreshold")] public CFloat MinRumbleVelocityThreshold { get; set; }
		[Ordinal(7)]  [RED("rumbleCooldown")] public CFloat RumbleCooldown { get; set; }
		[Ordinal(8)]  [RED("scrapingMaxCollisionCooldown")] public CFloat ScrapingMaxCollisionCooldown { get; set; }
		[Ordinal(9)]  [RED("scrapingMinTangentialVelocityThreshold")] public CFloat ScrapingMinTangentialVelocityThreshold { get; set; }
		[Ordinal(10)]  [RED("scrapingMinVehicleUpCollisionContactAngle")] public CFloat ScrapingMinVehicleUpCollisionContactAngle { get; set; }
		[Ordinal(11)]  [RED("useScrapingMinVehicleUpCollisionContactAngle")] public CBool UseScrapingMinVehicleUpCollisionContactAngle { get; set; }

		public audioVehicleCollisionMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
