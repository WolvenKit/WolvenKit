using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStoryScene : CResource
	{
		[RED("controlParts", 2,0)] 		public CArray<CPtr<CStorySceneControlPart>> ControlParts { get; set;}

		[RED("sections", 2,0)] 		public CArray<CPtr<CStorySceneSection>> Sections { get; set;}

		[RED("elementIDCounter")] 		public CUInt32 ElementIDCounter { get; set;}

		[RED("sectionIDCounter")] 		public CUInt32 SectionIDCounter { get; set;}

		[RED("sceneId")] 		public CUInt32 SceneId { get; set;}

		[RED("sceneTemplates", 2,0)] 		public CArray<CPtr<CStorySceneActor>> SceneTemplates { get; set;}

		[RED("sceneProps", 2,0)] 		public CArray<CPtr<CStorySceneProp>> SceneProps { get; set;}

		[RED("sceneEffects", 2,0)] 		public CArray<CPtr<CStorySceneEffect>> SceneEffects { get; set;}

		[RED("sceneLights", 2,0)] 		public CArray<CPtr<CStorySceneLight>> SceneLights { get; set;}

		[RED("mayActorsStartWorking")] 		public CBool MayActorsStartWorking { get; set;}

		[RED("surpassWaterRendering")] 		public CBool SurpassWaterRendering { get; set;}

		[RED("dialogsetInstances", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetInstance>> DialogsetInstances { get; set;}

		[RED("cameraDefinitions", 2,0)] 		public CArray<StorySceneCameraDefinition> CameraDefinitions { get; set;}

		[RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[RED("blockMusicTriggers")] 		public CBool BlockMusicTriggers { get; set;}

		[RED("muteSpeechUnderWater")] 		public CBool MuteSpeechUnderWater { get; set;}

		[RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[RED("soundEventsOnEnd", 2,0)] 		public CArray<CName> SoundEventsOnEnd { get; set;}

		[RED("soundEventsOnSkip", 2,0)] 		public CArray<CName> SoundEventsOnSkip { get; set;}

		public CStoryScene(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStoryScene(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}