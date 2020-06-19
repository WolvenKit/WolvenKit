using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCustomCamera : CStorySceneEventCamera
	{
		[RED("cameraTranslation")] 		public Vector CameraTranslation { get; set;}

		[RED("cameraRotation")] 		public EulerAngles CameraRotation { get; set;}

		[RED("cameraZoom")] 		public CFloat CameraZoom { get; set;}

		[RED("cameraFov")] 		public CFloat CameraFov { get; set;}

		[RED("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[RED("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		[RED("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[RED("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[RED("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[RED("cameraDefinition")] 		public StorySceneCameraDefinition CameraDefinition { get; set;}

		public CStorySceneEventCustomCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventCustomCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}