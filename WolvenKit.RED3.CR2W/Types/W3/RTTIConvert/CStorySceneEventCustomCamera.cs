using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCustomCamera : CStorySceneEventCamera
	{
		[Ordinal(1)] [RED("cameraTranslation")] 		public Vector CameraTranslation { get; set;}

		[Ordinal(2)] [RED("cameraRotation")] 		public EulerAngles CameraRotation { get; set;}

		[Ordinal(3)] [RED("cameraZoom")] 		public CFloat CameraZoom { get; set;}

		[Ordinal(4)] [RED("cameraFov")] 		public CFloat CameraFov { get; set;}

		[Ordinal(5)] [RED("dofFocusDistFar")] 		public CFloat DofFocusDistFar { get; set;}

		[Ordinal(6)] [RED("dofBlurDistFar")] 		public CFloat DofBlurDistFar { get; set;}

		[Ordinal(7)] [RED("dofIntensity")] 		public CFloat DofIntensity { get; set;}

		[Ordinal(8)] [RED("dofFocusDistNear")] 		public CFloat DofFocusDistNear { get; set;}

		[Ordinal(9)] [RED("dofBlurDistNear")] 		public CFloat DofBlurDistNear { get; set;}

		[Ordinal(10)] [RED("cameraDefinition")] 		public StorySceneCameraDefinition CameraDefinition { get; set;}

		public CStorySceneEventCustomCamera(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventCustomCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}