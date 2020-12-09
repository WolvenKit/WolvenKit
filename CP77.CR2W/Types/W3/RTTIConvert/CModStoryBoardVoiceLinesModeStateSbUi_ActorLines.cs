using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardVoiceLinesModeStateSbUi_ActorLines : CModSbListViewWorkModeStateSbUi_FilteredListSelect
	{
		[Ordinal(1)] [RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[Ordinal(2)] [RED("newVoiceLine")] 		public SStoryBoardAudioSettings NewVoiceLine { get; set;}

		public CModStoryBoardVoiceLinesModeStateSbUi_ActorLines(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardVoiceLinesModeStateSbUi_ActorLines(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}