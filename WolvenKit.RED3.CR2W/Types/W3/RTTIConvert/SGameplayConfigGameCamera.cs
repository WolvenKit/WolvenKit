using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfigGameCamera : CVariable
	{
		[Ordinal(1)] [RED("verManualMax")] 		public CFloat VerManualMax { get; set;}

		[Ordinal(2)] [RED("verManualMin")] 		public CFloat VerManualMin { get; set;}

		[Ordinal(3)] [RED("horDamping")] 		public CFloat HorDamping { get; set;}

		[Ordinal(4)] [RED("verDamping")] 		public CFloat VerDamping { get; set;}

		[Ordinal(5)] [RED("pivotDamp")] 		public CFloat PivotDamp { get; set;}

		[Ordinal(6)] [RED("focusTargetDamp")] 		public CFloat FocusTargetDamp { get; set;}

		[Ordinal(7)] [RED("focusActDuration")] 		public CFloat FocusActDuration { get; set;}

		[Ordinal(8)] [RED("zoomDamp")] 		public CFloat ZoomDamp { get; set;}

		[Ordinal(9)] [RED("zoomActTime")] 		public CFloat ZoomActTime { get; set;}

		[Ordinal(10)] [RED("verOffsetDamp")] 		public CFloat VerOffsetDamp { get; set;}

		[Ordinal(11)] [RED("verOffsetActTime")] 		public CFloat VerOffsetActTime { get; set;}

		[Ordinal(12)] [RED("backOffsetDamp")] 		public CFloat BackOffsetDamp { get; set;}

		[Ordinal(13)] [RED("collisionDampOn")] 		public CFloat CollisionDampOn { get; set;}

		[Ordinal(14)] [RED("collisionDampOff")] 		public CFloat CollisionDampOff { get; set;}

		[Ordinal(15)] [RED("collisionBigRadius")] 		public CFloat CollisionBigRadius { get; set;}

		[Ordinal(16)] [RED("collisionBoxScale")] 		public CFloat CollisionBoxScale { get; set;}

		[Ordinal(17)] [RED("collisionAutoRotDamp")] 		public CFloat CollisionAutoRotDamp { get; set;}

		[Ordinal(18)] [RED("collisionAutoRotMaxSpeed")] 		public CFloat CollisionAutoRotMaxSpeed { get; set;}

		[Ordinal(19)] [RED("collisionVerCorrection")] 		public CFloat CollisionVerCorrection { get; set;}

		[Ordinal(20)] [RED("collisionPivotHeightOffset")] 		public CFloat CollisionPivotHeightOffset { get; set;}

		[Ordinal(21)] [RED("collisionPivotRadius")] 		public CFloat CollisionPivotRadius { get; set;}

		[Ordinal(22)] [RED("collisionVerRadius")] 		public CFloat CollisionVerRadius { get; set;}

		[Ordinal(23)] [RED("collisionVerOffsetP")] 		public CFloat CollisionVerOffsetP { get; set;}

		[Ordinal(24)] [RED("collisionVerOffsetM")] 		public CFloat CollisionVerOffsetM { get; set;}

		[Ordinal(25)] [RED("collisionVerFactor")] 		public CFloat CollisionVerFactor { get; set;}

		[Ordinal(26)] [RED("collisionVerRadiusP")] 		public CFloat CollisionVerRadiusP { get; set;}

		[Ordinal(27)] [RED("collisionVerRadiusM")] 		public CFloat CollisionVerRadiusM { get; set;}

		[Ordinal(28)] [RED("collisionAutoRotTrace")] 		public CBool CollisionAutoRotTrace { get; set;}

		[Ordinal(29)] [RED("collisionAutoRotTraceFactor")] 		public CFloat CollisionAutoRotTraceFactor { get; set;}

		[Ordinal(30)] [RED("indoorCollisionMaxZoom")] 		public CFloat IndoorCollisionMaxZoom { get; set;}

		[Ordinal(31)] [RED("slopeVerFactor")] 		public CFloat SlopeVerFactor { get; set;}

		[Ordinal(32)] [RED("slopeVerDamp")] 		public CFloat SlopeVerDamp { get; set;}

		[Ordinal(33)] [RED("sensX")] 		public CFloat SensX { get; set;}

		[Ordinal(34)] [RED("sensY")] 		public CFloat SensY { get; set;}

		public SGameplayConfigGameCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigGameCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}