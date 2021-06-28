using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraMovementData : CVariable
	{
		[Ordinal(1)] [RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		[Ordinal(2)] [RED("pivotPositionController")] 		public CHandle<ICustomCameraPivotPositionController> PivotPositionController { get; set;}

		[Ordinal(3)] [RED("pivotRotationController")] 		public CHandle<ICustomCameraPivotRotationController> PivotRotationController { get; set;}

		[Ordinal(4)] [RED("pivotDistanceController")] 		public CHandle<ICustomCameraPivotDistanceController> PivotDistanceController { get; set;}

		[Ordinal(5)] [RED("pivotPositionValue")] 		public Vector PivotPositionValue { get; set;}

		[Ordinal(6)] [RED("pivotPositionVelocity")] 		public Vector PivotPositionVelocity { get; set;}

		[Ordinal(7)] [RED("pivotRotationValue")] 		public EulerAngles PivotRotationValue { get; set;}

		[Ordinal(8)] [RED("pivotRotationVelocity")] 		public EulerAngles PivotRotationVelocity { get; set;}

		[Ordinal(9)] [RED("pivotDistanceValue")] 		public CFloat PivotDistanceValue { get; set;}

		[Ordinal(10)] [RED("pivotDistanceVelocity")] 		public CFloat PivotDistanceVelocity { get; set;}

		[Ordinal(11)] [RED("cameraLocalSpaceOffset")] 		public Vector CameraLocalSpaceOffset { get; set;}

		[Ordinal(12)] [RED("cameraLocalSpaceOffsetVel")] 		public Vector CameraLocalSpaceOffsetVel { get; set;}

		[Ordinal(13)] [RED("cameraOffset")] 		public Vector CameraOffset { get; set;}

		public SCameraMovementData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}