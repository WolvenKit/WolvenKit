using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardW2SceneDescrCreator : CObject
	{
		[Ordinal(1)] [RED("poseMgr")] 		public CHandle<CModStoryBoardIdlePoseListsManager> PoseMgr { get; set;}

		[Ordinal(2)] [RED("animMgr")] 		public CHandle<CModStoryBoardAnimationListsManager> AnimMgr { get; set;}

		[Ordinal(3)] [RED("mimicsMgr")] 		public CHandle<CModStoryBoardMimicsListsManager> MimicsMgr { get; set;}

		[Ordinal(4)] [RED("voiceLinesMgr")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesMgr { get; set;}

		[Ordinal(5)] [RED("thePlacement")] 		public CHandle<CModStoryBoardPlacementDirector> ThePlacement { get; set;}

		[Ordinal(6)] [RED("theLookAtDirector")] 		public CHandle<CModStoryBoardLookAtDirector> TheLookAtDirector { get; set;}

		[Ordinal(7)] [RED("repoActors", 2,0)] 		public CArray<SSbDescActor> RepoActors { get; set;}

		[Ordinal(8)] [RED("repoItems", 2,0)] 		public CArray<SSbDescItem> RepoItems { get; set;}

		[Ordinal(9)] [RED("repoCameras", 2,0)] 		public CArray<SSbDescCamera> RepoCameras { get; set;}

		[Ordinal(10)] [RED("playerTemplate")] 		public CString PlayerTemplate { get; set;}

		public CModStoryBoardW2SceneDescrCreator(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardW2SceneDescrCreator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}