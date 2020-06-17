using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCamera : CEntity
	{
		[RED("pivotPositionControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotPositionController>> PivotPositionControllers { get; set;}

		[RED("pivotRotationControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotRotationController>> PivotRotationControllers { get; set;}

		[RED("pivotDistanceControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotDistanceController>> PivotDistanceControllers { get; set;}

		[RED("activeCameraPositionController")] 		public CPtr<ICustomCameraPositionController> ActiveCameraPositionController { get; set;}

		[RED("blendPivotPositionController")] 		public CPtr<CCustomCameraBlendPPC> BlendPivotPositionController { get; set;}

		[RED("allowAutoRotation")] 		public CBool AllowAutoRotation { get; set;}

		[RED("manualRotationHorTimeout")] 		public CFloat ManualRotationHorTimeout { get; set;}

		[RED("manualRotationVerTimeout")] 		public CFloat ManualRotationVerTimeout { get; set;}

		[RED("fov")] 		public CFloat Fov { get; set;}

		[RED("animSet")] 		public CHandle<CSkeletalAnimationSet> AnimSet { get; set;}

		[RED("presets", 2,0)] 		public CArray<SCustomCameraPreset> Presets { get; set;}

		[RED("curveSet", 2,0)] 		public CArray<CPtr<CCurve>> CurveSet { get; set;}

		[RED("curveNames", 2,0)] 		public CArray<CName> CurveNames { get; set;}

		public CCustomCamera(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCustomCamera(cr2w);

	}
}