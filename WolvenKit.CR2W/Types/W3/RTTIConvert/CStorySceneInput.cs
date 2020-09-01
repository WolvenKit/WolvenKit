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
		[Ordinal(0)] [RED("inputName")] 		public CString InputName { get; set;}

		[Ordinal(0)] [RED("voicetagMappings", 2,0)] 		public CArray<CStorySceneVoicetagMapping> VoicetagMappings { get; set;}

		[Ordinal(0)] [RED("musicState")] 		public CEnum<ESoundStateDuringScene> MusicState { get; set;}

		[Ordinal(0)] [RED("ambientsState")] 		public CEnum<ESoundStateDuringScene> AmbientsState { get; set;}

		[Ordinal(0)] [RED("sceneNearPlane")] 		public CEnum<ENearPlaneDistance> SceneNearPlane { get; set;}

		[Ordinal(0)] [RED("sceneFarPlane")] 		public CEnum<EFarPlaneDistance> SceneFarPlane { get; set;}

		[Ordinal(0)] [RED("dontStopByExternalSystems")] 		public CBool DontStopByExternalSystems { get; set;}

		[Ordinal(0)] [RED("maxActorsStaryingDistanceFromPlacement")] 		public CFloat MaxActorsStaryingDistanceFromPlacement { get; set;}

		[Ordinal(0)] [RED("maxActorsStartingDistanceFormPlayer")] 		public CFloat MaxActorsStartingDistanceFormPlayer { get; set;}

		[Ordinal(0)] [RED("dialogsetPlacementTag")] 		public CName DialogsetPlacementTag { get; set;}

		[Ordinal(0)] [RED("dialogsetInstanceName")] 		public CName DialogsetInstanceName { get; set;}

		[Ordinal(0)] [RED("enableIntroVehicleDismount")] 		public CBool EnableIntroVehicleDismount { get; set;}

		[Ordinal(0)] [RED("enableIntroLookAts")] 		public CBool EnableIntroLookAts { get; set;}

		[Ordinal(0)] [RED("introTotalTime")] 		public CFloat IntroTotalTime { get; set;}

		[Ordinal(0)] [RED("enableIntroFadeOut")] 		public CBool EnableIntroFadeOut { get; set;}

		[Ordinal(0)] [RED("introFadeOutStartTime")] 		public CFloat IntroFadeOutStartTime { get; set;}

		[Ordinal(0)] [RED("blockSceneArea")] 		public CBool BlockSceneArea { get; set;}

		[Ordinal(0)] [RED("enableDestroyDeadActorsAround")] 		public CBool EnableDestroyDeadActorsAround { get; set;}

		[Ordinal(0)] [RED("isImportant")] 		public CBool IsImportant { get; set;}

		[Ordinal(0)] [RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		public CStorySceneInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}