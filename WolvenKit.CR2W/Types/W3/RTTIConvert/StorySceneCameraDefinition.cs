using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class StorySceneCameraDefinition : CVariable
	{
		[Ordinal(0)] [RED("("cameraName")] 		public CName CameraName { get; set;}

		[Ordinal(0)] [RED("("cameraTransform")] 		public EngineTransform CameraTransform { get; set;}

		[Ordinal(0)] [RED("("cameraZoom")] 		public CFloat CameraZoom { get; set;}

		[Ordinal(0)] [RED("("cameraFov")] 		public CFloat CameraFov { get; set;}

		[Ordinal(0)] [RED("("enableCameraNoise")] 		public CBool EnableCameraNoise { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		[Ordinal(0)] [RED("("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[Ordinal(0)] [RED("("sourceSlotName")] 		public CName SourceSlotName { get; set;}

		[Ordinal(0)] [RED("("targetSlotName")] 		public CName TargetSlotName { get; set;}

		[Ordinal(0)] [RED("("sourceEyesHeigth")] 		public CFloat SourceEyesHeigth { get; set;}

		[Ordinal(0)] [RED("("targetEyesLS")] 		public Vector TargetEyesLS { get; set;}

		[Ordinal(0)] [RED("("dof")] 		public ApertureDofParams Dof { get; set;}

		[Ordinal(0)] [RED("("bokehDofParams")] 		public SBokehDofParams BokehDofParams { get; set;}

		[Ordinal(0)] [RED("("genParam")] 		public CEventGeneratorCameraParams GenParam { get; set;}

		[Ordinal(0)] [RED("("cameraAdjustVersion")] 		public CUInt8 CameraAdjustVersion { get; set;}

		public StorySceneCameraDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new StorySceneCameraDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}