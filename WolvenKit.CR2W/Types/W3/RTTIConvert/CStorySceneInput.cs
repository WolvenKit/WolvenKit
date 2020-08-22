using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneInput : CStorySceneControlPart
	{
		[RED("inputName")] 		public CString InputName { get; set;}

		[RED("voicetagMappings", 2,0)] 		public CArray<CStorySceneVoicetagMapping> VoicetagMappings { get; set;}

		[RED("musicState")] 		public CEnum<ESoundStateDuringScene> MusicState { get; set;}

		[RED("ambientsState")] 		public CEnum<ESoundStateDuringScene> AmbientsState { get; set;}

		[RED("sceneNearPlane")] 		public CEnum<ENearPlaneDistance> SceneNearPlane { get; set;}

		[RED("sceneFarPlane")] 		public CEnum<EFarPlaneDistance> SceneFarPlane { get; set;}

		[RED("dontStopByExternalSystems")] 		public CBool DontStopByExternalSystems { get; set;}

		[RED("maxActorsStaryingDistanceFromPlacement")] 		public CFloat MaxActorsStaryingDistanceFromPlacement { get; set;}

		[RED("maxActorsStartingDistanceFormPlayer")] 		public CFloat MaxActorsStartingDistanceFormPlayer { get; set;}

		[RED("dialogsetPlacementTag")] 		public CName DialogsetPlacementTag { get; set;}

		[RED("dialogsetInstanceName")] 		public CName DialogsetInstanceName { get; set;}

		[RED("enableIntroVehicleDismount")] 		public CBool EnableIntroVehicleDismount { get; set;}

		[RED("enableIntroLookAts")] 		public CBool EnableIntroLookAts { get; set;}

		[RED("introTotalTime")] 		public CFloat IntroTotalTime { get; set;}

		[RED("enableIntroFadeOut")] 		public CBool EnableIntroFadeOut { get; set;}

		[RED("introFadeOutStartTime")] 		public CFloat IntroFadeOutStartTime { get; set;}

		[RED("blockSceneArea")] 		public CBool BlockSceneArea { get; set;}

		[RED("enableDestroyDeadActorsAround")] 		public CBool EnableDestroyDeadActorsAround { get; set;}

		[RED("isImportant")] 		public CBool IsImportant { get; set;}

		[RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		public CStorySceneInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}