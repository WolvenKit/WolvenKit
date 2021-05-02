using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCustomCamera : CEntity
	{
		[Ordinal(1)] [RED("pivotPositionControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotPositionController>> PivotPositionControllers { get; set;}

		[Ordinal(2)] [RED("pivotRotationControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotRotationController>> PivotRotationControllers { get; set;}

		[Ordinal(3)] [RED("pivotDistanceControllers", 2,0)] 		public CArray<CPtr<ICustomCameraPivotDistanceController>> PivotDistanceControllers { get; set;}

		[Ordinal(4)] [RED("activeCameraPositionController")] 		public CPtr<ICustomCameraPositionController> ActiveCameraPositionController { get; set;}

		[Ordinal(5)] [RED("blendPivotPositionController")] 		public CPtr<CCustomCameraBlendPPC> BlendPivotPositionController { get; set;}

		[Ordinal(6)] [RED("allowAutoRotation")] 		public CBool AllowAutoRotation { get; set;}

		[Ordinal(7)] [RED("manualRotationHorTimeout")] 		public CFloat ManualRotationHorTimeout { get; set;}

		[Ordinal(8)] [RED("manualRotationVerTimeout")] 		public CFloat ManualRotationVerTimeout { get; set;}

		[Ordinal(9)] [RED("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(10)] [RED("animSet")] 		public CHandle<CSkeletalAnimationSet> AnimSet { get; set;}

		[Ordinal(11)] [RED("presets", 2,0)] 		public CArray<SCustomCameraPreset> Presets { get; set;}

		[Ordinal(12)] [RED("curveSet", 2,0)] 		public CArray<CPtr<CCurve>> CurveSet { get; set;}

		[Ordinal(13)] [RED("curveNames", 2,0)] 		public CArray<CName> CurveNames { get; set;}

		public CCustomCamera(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCustomCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}