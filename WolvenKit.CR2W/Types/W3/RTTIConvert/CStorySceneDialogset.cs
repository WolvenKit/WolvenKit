using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneDialogset : CSkeletalAnimationSet
	{
		[Ordinal(0)] [RED("("dialogsetName")] 		public CName DialogsetName { get; set;}

		[Ordinal(0)] [RED("("dialogsetTransitionEvent")] 		public CName DialogsetTransitionEvent { get; set;}

		[Ordinal(0)] [RED("("isDynamic")] 		public CBool IsDynamic { get; set;}

		[Ordinal(0)] [RED("("characterTrajectories", 2,0)] 		public CArray<EngineTransform> CharacterTrajectories { get; set;}

		[Ordinal(0)] [RED("("cameraTrajectories", 2,0)] 		public CArray<EngineTransform> CameraTrajectories { get; set;}

		[Ordinal(0)] [RED("("personalCameras", 2,0)] 		public CArray<SScenePersonalCameraDescription> PersonalCameras { get; set;}

		[Ordinal(0)] [RED("("masterCameras", 2,0)] 		public CArray<SSceneMasterCameraDescription> MasterCameras { get; set;}

		[Ordinal(0)] [RED("("customCameras", 2,0)] 		public CArray<SSceneCustomCameraDescription> CustomCameras { get; set;}

		[Ordinal(0)] [RED("("cameraEyePositions", 2,0)] 		public CArray<Vector> CameraEyePositions { get; set;}

		[Ordinal(0)] [RED("("slots", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetSlot>> Slots { get; set;}

		[Ordinal(0)] [RED("("cameras", 2,0)] 		public CArray<StorySceneCameraDefinition> Cameras { get; set;}

		public CStorySceneDialogset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneDialogset(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}