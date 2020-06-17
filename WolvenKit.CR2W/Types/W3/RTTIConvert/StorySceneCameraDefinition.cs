using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class StorySceneCameraDefinition : CVariable
	{
		[RED("cameraName")] 		public CName CameraName { get; set;}

		[RED("cameraTransform")] 		public EngineTransform CameraTransform { get; set;}

		[RED("cameraZoom")] 		public CFloat CameraZoom { get; set;}

		[RED("cameraFov")] 		public CFloat CameraFov { get; set;}

		[RED("enableCameraNoise")] 		public CBool EnableCameraNoise { get; set;}

		[RED("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[RED("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		[RED("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[RED("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[RED("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[RED("sourceSlotName")] 		public CName SourceSlotName { get; set;}

		[RED("targetSlotName")] 		public CName TargetSlotName { get; set;}

		[RED("sourceEyesHeigth")] 		public CFloat SourceEyesHeigth { get; set;}

		[RED("targetEyesLS")] 		public Vector TargetEyesLS { get; set;}

		[RED("dof")] 		public ApertureDofParams Dof { get; set;}

		[RED("bokehDofParams")] 		public SBokehDofParams BokehDofParams { get; set;}

		[RED("genParam")] 		public CEventGeneratorCameraParams GenParam { get; set;}

		[RED("cameraAdjustVersion")] 		public CUInt8 CameraAdjustVersion { get; set;}

		public StorySceneCameraDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new StorySceneCameraDefinition(cr2w);

	}
}