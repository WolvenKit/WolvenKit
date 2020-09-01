using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardW2SceneDescrCreator : CObject
	{
		[Ordinal(0)] [RED("poseMgr")] 		public CHandle<CModStoryBoardIdlePoseListsManager> PoseMgr { get; set;}

		[Ordinal(0)] [RED("animMgr")] 		public CHandle<CModStoryBoardAnimationListsManager> AnimMgr { get; set;}

		[Ordinal(0)] [RED("mimicsMgr")] 		public CHandle<CModStoryBoardMimicsListsManager> MimicsMgr { get; set;}

		[Ordinal(0)] [RED("voiceLinesMgr")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesMgr { get; set;}

		[Ordinal(0)] [RED("thePlacement")] 		public CHandle<CModStoryBoardPlacementDirector> ThePlacement { get; set;}

		[Ordinal(0)] [RED("theLookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> TheLookAtDirector { get; set;}

		[Ordinal(0)] [RED("repoActors", 2,0)] 		public CArray<SSbDescActor> RepoActors { get; set;}

		[Ordinal(0)] [RED("repoItems", 2,0)] 		public CArray<SSbDescItem> RepoItems { get; set;}

		[Ordinal(0)] [RED("repoCameras", 2,0)] 		public CArray<SSbDescCamera> RepoCameras { get; set;}

		[Ordinal(0)] [RED("playerTemplate")] 		public CString PlayerTemplate { get; set;}

		public CModStoryBoardW2SceneDescrCreator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardW2SceneDescrCreator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}