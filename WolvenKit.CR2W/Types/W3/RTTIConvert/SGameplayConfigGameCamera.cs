using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGameplayConfigGameCamera : CVariable
	{
		[RED("verManualMax")] 		public CFloat VerManualMax { get; set;}

		[RED("verManualMin")] 		public CFloat VerManualMin { get; set;}

		[RED("horDamping")] 		public CFloat HorDamping { get; set;}

		[RED("verDamping")] 		public CFloat VerDamping { get; set;}

		[RED("pivotDamp")] 		public CFloat PivotDamp { get; set;}

		[RED("focusTargetDamp")] 		public CFloat FocusTargetDamp { get; set;}

		[RED("focusActDuration")] 		public CFloat FocusActDuration { get; set;}

		[RED("zoomDamp")] 		public CFloat ZoomDamp { get; set;}

		[RED("zoomActTime")] 		public CFloat ZoomActTime { get; set;}

		[RED("verOffsetDamp")] 		public CFloat VerOffsetDamp { get; set;}

		[RED("verOffsetActTime")] 		public CFloat VerOffsetActTime { get; set;}

		[RED("backOffsetDamp")] 		public CFloat BackOffsetDamp { get; set;}

		[RED("collisionDampOn")] 		public CFloat CollisionDampOn { get; set;}

		[RED("collisionDampOff")] 		public CFloat CollisionDampOff { get; set;}

		[RED("collisionBigRadius")] 		public CFloat CollisionBigRadius { get; set;}

		[RED("collisionBoxScale")] 		public CFloat CollisionBoxScale { get; set;}

		[RED("collisionAutoRotDamp")] 		public CFloat CollisionAutoRotDamp { get; set;}

		[RED("collisionAutoRotMaxSpeed")] 		public CFloat CollisionAutoRotMaxSpeed { get; set;}

		[RED("collisionVerCorrection")] 		public CFloat CollisionVerCorrection { get; set;}

		[RED("collisionPivotHeightOffset")] 		public CFloat CollisionPivotHeightOffset { get; set;}

		[RED("collisionPivotRadius")] 		public CFloat CollisionPivotRadius { get; set;}

		[RED("collisionVerRadius")] 		public CFloat CollisionVerRadius { get; set;}

		[RED("collisionVerOffsetP")] 		public CFloat CollisionVerOffsetP { get; set;}

		[RED("collisionVerOffsetM")] 		public CFloat CollisionVerOffsetM { get; set;}

		[RED("collisionVerFactor")] 		public CFloat CollisionVerFactor { get; set;}

		[RED("collisionVerRadiusP")] 		public CFloat CollisionVerRadiusP { get; set;}

		[RED("collisionVerRadiusM")] 		public CFloat CollisionVerRadiusM { get; set;}

		[RED("collisionAutoRotTrace")] 		public CBool CollisionAutoRotTrace { get; set;}

		[RED("collisionAutoRotTraceFactor")] 		public CFloat CollisionAutoRotTraceFactor { get; set;}

		[RED("indoorCollisionMaxZoom")] 		public CFloat IndoorCollisionMaxZoom { get; set;}

		[RED("slopeVerFactor")] 		public CFloat SlopeVerFactor { get; set;}

		[RED("slopeVerDamp")] 		public CFloat SlopeVerDamp { get; set;}

		[RED("sensX")] 		public CFloat SensX { get; set;}

		[RED("sensY")] 		public CFloat SensY { get; set;}

		public SGameplayConfigGameCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGameplayConfigGameCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}