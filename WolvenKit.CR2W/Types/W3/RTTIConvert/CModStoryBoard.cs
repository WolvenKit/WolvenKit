using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoard : CObject
	{
		[Ordinal(0)] [RED("("log")] 		public CHandle<CModLogger> Log { get; set;}

		[Ordinal(0)] [RED("("shotViewer")] 		public CHandle<CModStoryBoardShotViewer> ShotViewer { get; set;}

		[Ordinal(0)] [RED("("assetManager")] 		public CHandle<CModStoryBoardAssetManager> AssetManager { get; set;}

		[Ordinal(0)] [RED("("idlePoseListsManager")] 		public CHandle<CModStoryBoardIdlePoseListsManager> IdlePoseListsManager { get; set;}

		[Ordinal(0)] [RED("("animListsManager")] 		public CHandle<CModStoryBoardAnimationListsManager> AnimListsManager { get; set;}

		[Ordinal(0)] [RED("("mimicsListsManager")] 		public CHandle<CModStoryBoardMimicsListsManager> MimicsListsManager { get; set;}

		[Ordinal(0)] [RED("("voiceLinesListsManager")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesListsManager { get; set;}

		[Ordinal(0)] [RED("("shots", 2,0)] 		public CArray<CHandle<CModStoryBoardShot>> Shots { get; set;}

		[Ordinal(0)] [RED("("currentShotSlot")] 		public CInt32 CurrentShotSlot { get; set;}

		public CModStoryBoard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoard(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}