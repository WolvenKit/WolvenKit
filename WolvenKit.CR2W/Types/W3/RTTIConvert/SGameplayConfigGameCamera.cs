using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfigGameCamera : CVariable
	{
		[Ordinal(0)] [RED("("verManualMax")] 		public CFloat VerManualMax { get; set;}

		[Ordinal(0)] [RED("("verManualMin")] 		public CFloat VerManualMin { get; set;}

		[Ordinal(0)] [RED("("horDamping")] 		public CFloat HorDamping { get; set;}

		[Ordinal(0)] [RED("("verDamping")] 		public CFloat VerDamping { get; set;}

		[Ordinal(0)] [RED("("pivotDamp")] 		public CFloat PivotDamp { get; set;}

		[Ordinal(0)] [RED("("focusTargetDamp")] 		public CFloat FocusTargetDamp { get; set;}

		[Ordinal(0)] [RED("("focusActDuration")] 		public CFloat FocusActDuration { get; set;}

		[Ordinal(0)] [RED("("zoomDamp")] 		public CFloat ZoomDamp { get; set;}

		[Ordinal(0)] [RED("("zoomActTime")] 		public CFloat ZoomActTime { get; set;}

		[Ordinal(0)] [RED("("verOffsetDamp")] 		public CFloat VerOffsetDamp { get; set;}

		[Ordinal(0)] [RED("("verOffsetActTime")] 		public CFloat VerOffsetActTime { get; set;}

		[Ordinal(0)] [RED("("backOffsetDamp")] 		public CFloat BackOffsetDamp { get; set;}

		[Ordinal(0)] [RED("("collisionDampOn")] 		public CFloat CollisionDampOn { get; set;}

		[Ordinal(0)] [RED("("collisionDampOff")] 		public CFloat CollisionDampOff { get; set;}

		[Ordinal(0)] [RED("("collisionBigRadius")] 		public CFloat CollisionBigRadius { get; set;}

		[Ordinal(0)] [RED("("collisionBoxScale")] 		public CFloat CollisionBoxScale { get; set;}

		[Ordinal(0)] [RED("("collisionAutoRotDamp")] 		public CFloat CollisionAutoRotDamp { get; set;}

		[Ordinal(0)] [RED("("collisionAutoRotMaxSpeed")] 		public CFloat CollisionAutoRotMaxSpeed { get; set;}

		[Ordinal(0)] [RED("("collisionVerCorrection")] 		public CFloat CollisionVerCorrection { get; set;}

		[Ordinal(0)] [RED("("collisionPivotHeightOffset")] 		public CFloat CollisionPivotHeightOffset { get; set;}

		[Ordinal(0)] [RED("("collisionPivotRadius")] 		public CFloat CollisionPivotRadius { get; set;}

		[Ordinal(0)] [RED("("collisionVerRadius")] 		public CFloat CollisionVerRadius { get; set;}

		[Ordinal(0)] [RED("("collisionVerOffsetP")] 		public CFloat CollisionVerOffsetP { get; set;}

		[Ordinal(0)] [RED("("collisionVerOffsetM")] 		public CFloat CollisionVerOffsetM { get; set;}

		[Ordinal(0)] [RED("("collisionVerFactor")] 		public CFloat CollisionVerFactor { get; set;}

		[Ordinal(0)] [RED("("collisionVerRadiusP")] 		public CFloat CollisionVerRadiusP { get; set;}

		[Ordinal(0)] [RED("("collisionVerRadiusM")] 		public CFloat CollisionVerRadiusM { get; set;}

		[Ordinal(0)] [RED("("collisionAutoRotTrace")] 		public CBool CollisionAutoRotTrace { get; set;}

		[Ordinal(0)] [RED("("collisionAutoRotTraceFactor")] 		public CFloat CollisionAutoRotTraceFactor { get; set;}

		[Ordinal(0)] [RED("("indoorCollisionMaxZoom")] 		public CFloat IndoorCollisionMaxZoom { get; set;}

		[Ordinal(0)] [RED("("slopeVerFactor")] 		public CFloat SlopeVerFactor { get; set;}

		[Ordinal(0)] [RED("("slopeVerDamp")] 		public CFloat SlopeVerDamp { get; set;}

		[Ordinal(0)] [RED("("sensX")] 		public CFloat SensX { get; set;}

		[Ordinal(0)] [RED("("sensY")] 		public CFloat SensY { get; set;}

		public SGameplayConfigGameCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigGameCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}