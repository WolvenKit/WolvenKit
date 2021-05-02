using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStoryScene : CResource
	{
		[Ordinal(1)] [RED("controlParts", 2,0)] 		public CArray<CPtr<CStorySceneControlPart>> ControlParts { get; set;}

		[Ordinal(2)] [RED("sections", 2,0)] 		public CArray<CPtr<CStorySceneSection>> Sections { get; set;}

		[Ordinal(3)] [RED("graph")] 		public CPtr<CStorySceneGraph> Graph { get; set;}

		[Ordinal(4)] [RED("layerPreset")] 		public CString LayerPreset { get; set;}

		[Ordinal(5)] [RED("elementIDCounter")] 		public CUInt32 ElementIDCounter { get; set;}

		[Ordinal(6)] [RED("sectionIDCounter")] 		public CUInt32 SectionIDCounter { get; set;}

		[Ordinal(7)] [RED("sceneId")] 		public CUInt32 SceneId { get; set;}

		[Ordinal(8)] [RED("sceneTemplates", 2,0)] 		public CArray<CPtr<CStorySceneActor>> SceneTemplates { get; set;}

		[Ordinal(9)] [RED("sceneProps", 2,0)] 		public CArray<CPtr<CStorySceneProp>> SceneProps { get; set;}

		[Ordinal(10)] [RED("sceneEffects", 2,0)] 		public CArray<CPtr<CStorySceneEffect>> SceneEffects { get; set;}

		[Ordinal(11)] [RED("sceneLights", 2,0)] 		public CArray<CPtr<CStorySceneLight>> SceneLights { get; set;}

		[Ordinal(12)] [RED("mayActorsStartWorking")] 		public CBool MayActorsStartWorking { get; set;}

		[Ordinal(13)] [RED("surpassWaterRendering")] 		public CBool SurpassWaterRendering { get; set;}

		[Ordinal(14)] [RED("dialogsetInstances", 2,0)] 		public CArray<CPtr<CStorySceneDialogsetInstance>> DialogsetInstances { get; set;}

		[Ordinal(15)] [RED("cameraDefinitions", 2,0)] 		public CArray<StorySceneCameraDefinition> CameraDefinitions { get; set;}

		[Ordinal(16)] [RED("banksDependency", 2,0)] 		public CArray<CName> BanksDependency { get; set;}

		[Ordinal(17)] [RED("blockMusicTriggers")] 		public CBool BlockMusicTriggers { get; set;}

		[Ordinal(18)] [RED("muteSpeechUnderWater")] 		public CBool MuteSpeechUnderWater { get; set;}

		[Ordinal(19)] [RED("soundListenerOverride")] 		public CString SoundListenerOverride { get; set;}

		[Ordinal(20)] [RED("soundEventsOnEnd", 2,0)] 		public CArray<CName> SoundEventsOnEnd { get; set;}

		[Ordinal(21)] [RED("soundEventsOnSkip", 2,0)] 		public CArray<CName> SoundEventsOnSkip { get; set;}

		public CStoryScene(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}