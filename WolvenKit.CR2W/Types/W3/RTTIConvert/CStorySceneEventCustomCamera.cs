using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCustomCamera : CStorySceneEventCamera
	{
		[Ordinal(0)] [RED("("cameraTranslation")] 		public Vector CameraTranslation { get; set;}

		[Ordinal(0)] [RED("("cameraRotation")] 		public EulerAngles CameraRotation { get; set;}

		[Ordinal(0)] [RED("("cameraZoom")] 		public CFloat CameraZoom { get; set;}

		[Ordinal(0)] [RED("("cameraFov")] 		public CFloat CameraFov { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		[Ordinal(0)] [RED("("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[Ordinal(0)] [RED("("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[Ordinal(0)] [RED("("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[Ordinal(0)] [RED("("cameraDefinition")] 		public StorySceneCameraDefinition CameraDefinition { get; set;}

		public CStorySceneEventCustomCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventCustomCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}