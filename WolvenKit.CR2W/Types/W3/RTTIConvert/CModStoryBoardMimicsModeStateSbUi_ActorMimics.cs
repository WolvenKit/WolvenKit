using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardMimicsModeStateSbUi_ActorMimics : CModSbListViewWorkModeStateSbUi_FilteredListSelect
	{
		[Ordinal(1)] [RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[Ordinal(2)] [RED("newMimics")] 		public SStoryBoardAnimationSettings NewMimics { get; set;}

		public CModStoryBoardMimicsModeStateSbUi_ActorMimics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardMimicsModeStateSbUi_ActorMimics(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}