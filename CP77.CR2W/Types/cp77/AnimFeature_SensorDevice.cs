using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SensorDevice : animAnimFeature
	{
		[Ordinal(0)]  [RED("currentRotation")] public Vector4 CurrentRotation { get; set; }
		[Ordinal(1)]  [RED("isCeiling")] public CBool IsCeiling { get; set; }
		[Ordinal(2)]  [RED("isControlled")] public CBool IsControlled { get; set; }
		[Ordinal(3)]  [RED("isDestroyed")] public CBool IsDestroyed { get; set; }
		[Ordinal(4)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(5)]  [RED("isTurnedOn")] public CBool IsTurnedOn { get; set; }
		[Ordinal(6)]  [RED("maxRotationAngle")] public CFloat MaxRotationAngle { get; set; }
		[Ordinal(7)]  [RED("overrideRootRotation")] public CFloat OverrideRootRotation { get; set; }
		[Ordinal(8)]  [RED("pitchAngle")] public CFloat PitchAngle { get; set; }
		[Ordinal(9)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(10)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(11)]  [RED("wakeState")] public CInt32 WakeState { get; set; }
		[Ordinal(12)]  [RED("wasHit")] public CBool WasHit { get; set; }

		public AnimFeature_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
