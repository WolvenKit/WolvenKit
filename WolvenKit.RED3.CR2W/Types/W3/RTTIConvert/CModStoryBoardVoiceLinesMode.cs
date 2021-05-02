using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardVoiceLinesMode : CModStoryBoardAssetSelectionBasedWorkMode
	{
		[Ordinal(1)] [RED("voiceLinesListsManager")] 		public CHandle<CModStoryBoardVoiceLinesListsManager> VoiceLinesListsManager { get; set;}

		[Ordinal(2)] [RED("theAudioDirector")] 		public CHandle<CModStoryBoardAudioDirector> TheAudioDirector { get; set;}

		public CModStoryBoardVoiceLinesMode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardVoiceLinesMode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}