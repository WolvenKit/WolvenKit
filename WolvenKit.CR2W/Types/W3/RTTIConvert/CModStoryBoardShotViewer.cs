using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardShotViewer : CEntity
	{
		[Ordinal(0)] [RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(0)] [RED("theShotCam")] 		public CHandle<CStoryBoardShotCamera> TheShotCam { get; set;}

		[Ordinal(0)] [RED("assetManager")] 		public CHandle<CModStoryBoardAssetManager> AssetManager { get; set;}

		[Ordinal(0)] [RED("animListsManager")] 		public CHandle<CModStoryBoardAnimationListsManager> AnimListsManager { get; set;}

		[Ordinal(0)] [RED("mimicsListsManager")] 		public CHandle<CModStoryBoardMimicsListsManager> MimicsListsManager { get; set;}

		[Ordinal(0)] [RED("voiceLinesListsManager")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesListsManager { get; set;}

		[Ordinal(0)] [RED("poseListManager")] 		public CHandle<CModStoryBoardIdlePoseListsManager> PoseListManager { get; set;}

		[Ordinal(0)] [RED("thePlacementDirector")] 		public CHandle<CModStoryBoardPlacementDirector> ThePlacementDirector { get; set;}

		[Ordinal(0)] [RED("theAnimDirector")] 		public CHandle<CModStoryBoardAnimationDirector> TheAnimDirector { get; set;}

		[Ordinal(0)] [RED("theLookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> TheLookAtDirector { get; set;}

		[Ordinal(0)] [RED("theAudioDirector")] 		public CHandle<CModStoryBoardAudioDirector> TheAudioDirector { get; set;}

		public CModStoryBoardShotViewer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardShotViewer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}