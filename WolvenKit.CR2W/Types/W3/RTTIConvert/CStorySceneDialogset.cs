using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogset : CSkeletalAnimationSet
	{
		[RED("dialogsetName")] 		public CName DialogsetName { get; set;}

		[RED("dialogsetTransitionEvent")] 		public CName DialogsetTransitionEvent { get; set;}

		[RED("isDynamic")] 		public CBool IsDynamic { get; set;}

		[RED("characterTrajectories", 2,0)] 		public CArray<EngineTransform> CharacterTrajectories { get; set;}

		[RED("cameraTrajectories", 2,0)] 		public CArray<EngineTransform> CameraTrajectories { get; set;}

		[RED("personalCameras", 2,0)] 		public CArray<SScenePersonalCameraDescription> PersonalCameras { get; set;}

		[RED("masterCameras", 2,0)] 		public CArray<SSceneMasterCameraDescription> MasterCameras { get; set;}

		[RED("customCameras", 2,0)] 		public CArray<SSceneCustomCameraDescription> CustomCameras { get; set;}

		[RED("cameraEyePositions", 2,0)] 		public CArray<Vector> CameraEyePositions { get; set;}

		[RED("slots", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetSlot>> Slots { get; set;}

		[RED("cameras", 2,0)] 		public CArray<StorySceneCameraDefinition> Cameras { get; set;}

		public CStorySceneDialogset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}