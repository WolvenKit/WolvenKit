using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCameraMovementData : CVariable
	{
		[RED("camera")] 		public CHandle<CCustomCamera> Camera { get; set;}

		[RED("pivotPositionController")] 		public CHandle<ICustomCameraPivotPositionController> PivotPositionController { get; set;}

		[RED("pivotRotationController")] 		public CHandle<ICustomCameraPivotRotationController> PivotRotationController { get; set;}

		[RED("pivotDistanceController")] 		public CHandle<ICustomCameraPivotDistanceController> PivotDistanceController { get; set;}

		[RED("pivotPositionValue")] 		public Vector PivotPositionValue { get; set;}

		[RED("pivotPositionVelocity")] 		public Vector PivotPositionVelocity { get; set;}

		[RED("pivotRotationValue")] 		public EulerAngles PivotRotationValue { get; set;}

		[RED("pivotRotationVelocity")] 		public EulerAngles PivotRotationVelocity { get; set;}

		[RED("pivotDistanceValue")] 		public CFloat PivotDistanceValue { get; set;}

		[RED("pivotDistanceVelocity")] 		public CFloat PivotDistanceVelocity { get; set;}

		[RED("cameraLocalSpaceOffset")] 		public Vector CameraLocalSpaceOffset { get; set;}

		[RED("cameraLocalSpaceOffsetVel")] 		public Vector CameraLocalSpaceOffsetVel { get; set;}

		[RED("cameraOffset")] 		public Vector CameraOffset { get; set;}

		public SCameraMovementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCameraMovementData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}