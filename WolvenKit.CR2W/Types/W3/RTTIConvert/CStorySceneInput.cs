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
		[Ordinal(1)] [RED("inputName")] 		public CString InputName { get; set;}

		[Ordinal(2)] [RED("voicetagMappings", 2,0)] 		public CArray<CStorySceneVoicetagMapping> VoicetagMappings { get; set;}

		[Ordinal(3)] [RED("musicState")] 		public CEnum<ESoundStateDuringScene> MusicState { get; set;}

		[Ordinal(4)] [RED("ambientsState")] 		public CEnum<ESoundStateDuringScene> AmbientsState { get; set;}

		[Ordinal(5)] [RED("sceneNearPlane")] 		public CEnum<ENearPlaneDistance> SceneNearPlane { get; set;}

		[Ordinal(6)] [RED("sceneFarPlane")] 		public CEnum<EFarPlaneDistance> SceneFarPlane { get; set;}

		[Ordinal(7)] [RED("dontStopByExternalSystems")] 		public CBool DontStopByExternalSystems { get; set;}

		[Ordinal(8)] [RED("maxActorsStaryingDistanceFromPlacement")] 		public CFloat MaxActorsStaryingDistanceFromPlacement { get; set;}

		[Ordinal(9)] [RED("maxActorsStartingDistanceFormPlayer")] 		public CFloat MaxActorsStartingDistanceFormPlayer { get; set;}

		[Ordinal(10)] [RED("dialogsetPlacementTag")] 		public CName DialogsetPlacementTag { get; set;}

		[Ordinal(11)] [RED("dialogsetInstanceName")] 		public CName DialogsetInstanceName { get; set;}

		[Ordinal(12)] [RED("enableIntroVehicleDismount")] 		public CBool EnableIntroVehicleDismount { get; set;}

		[Ordinal(13)] [RED("enableIntroLookAts")] 		public CBool EnableIntroLookAts { get; set;}

		[Ordinal(14)] [RED("introTotalTime")] 		public CFloat IntroTotalTime { get; set;}

		[Ordinal(15)] [RED("enableIntroFadeOut")] 		public CBool EnableIntroFadeOut { get; set;}

		[Ordinal(16)] [RED("introFadeOutStartTime")] 		public CFloat IntroFadeOutStartTime { get; set;}

		[Ordinal(17)] [RED("blockSceneArea")] 		public CBool BlockSceneArea { get; set;}

		[Ordinal(18)] [RED("enableDestroyDeadActorsAround")] 		public CBool EnableDestroyDeadActorsAround { get; set;}

		[Ordinal(19)] [RED("isImportant")] 		public CBool IsImportant { get; set;}

		[Ordinal(20)] [RED("isGameplay")] 		public CBool IsGameplay { get; set;}

		public CStorySceneInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneInput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}