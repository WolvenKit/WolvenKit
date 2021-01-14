using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassenger : animAnimFeature
	{
		[Ordinal(0)]  [RED("bankSpeed")] public CFloat BankSpeed { get; set; }
		[Ordinal(1)]  [RED("clutchInUse")] public CBool ClutchInUse { get; set; }
		[Ordinal(2)]  [RED("collisionForceFB")] public CFloat CollisionForceFB { get; set; }
		[Ordinal(3)]  [RED("collisionForceLR")] public CFloat CollisionForceLR { get; set; }
		[Ordinal(4)]  [RED("headCollision")] public CBool HeadCollision { get; set; }
		[Ordinal(5)]  [RED("inAir")] public CBool InAir { get; set; }
		[Ordinal(6)]  [RED("inputBreak")] public CFloat InputBreak { get; set; }
		[Ordinal(7)]  [RED("inputFB")] public CFloat InputFB { get; set; }
		[Ordinal(8)]  [RED("inputGas")] public CFloat InputGas { get; set; }
		[Ordinal(9)]  [RED("inputHandBreak")] public CFloat InputHandBreak { get; set; }
		[Ordinal(10)]  [RED("inputLR")] public CFloat InputLR { get; set; }
		[Ordinal(11)]  [RED("isCar")] public CBool IsCar { get; set; }
		[Ordinal(12)]  [RED("longitudinalForce")] public CFloat LongitudinalForce { get; set; }
		[Ordinal(13)]  [RED("overallForceMS")] public Vector4 OverallForceMS { get; set; }
		[Ordinal(14)]  [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(15)]  [RED("transversalForce")] public CFloat TransversalForce { get; set; }
		[Ordinal(16)]  [RED("turnSpeed")] public CFloat TurnSpeed { get; set; }
		[Ordinal(17)]  [RED("vehiclePitch")] public CFloat VehiclePitch { get; set; }
		[Ordinal(18)]  [RED("vehicleRoll")] public CFloat VehicleRoll { get; set; }

		public animAnimFeature_VehiclePassenger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
