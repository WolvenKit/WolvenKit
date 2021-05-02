using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoard : CObject
	{
		[Ordinal(1)] [RED("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(2)] [RED("shotViewer")] 		public CHandle<CModStoryBoardShotViewer> ShotViewer { get; set;}

		[Ordinal(3)] [RED("assetManager")] 		public CHandle<CModStoryBoardAssetManager> AssetManager { get; set;}

		[Ordinal(4)] [RED("idlePoseListsManager")] 		public CHandle<CModStoryBoardIdlePoseListsManager> IdlePoseListsManager { get; set;}

		[Ordinal(5)] [RED("animListsManager")] 		public CHandle<CModStoryBoardAnimationListsManager> AnimListsManager { get; set;}

		[Ordinal(6)] [RED("mimicsListsManager")] 		public CHandle<CModStoryBoardMimicsListsManager> MimicsListsManager { get; set;}

		[Ordinal(7)] [RED("voiceLinesListsManager")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesListsManager { get; set;}

		[Ordinal(8)] [RED("shots", 2,0)] 		public CArray<CHandle<CModStoryBoardShot>> Shots { get; set;}

		[Ordinal(9)] [RED("currentShotSlot")] 		public CInt32 CurrentShotSlot { get; set;}

		public CModStoryBoard(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}