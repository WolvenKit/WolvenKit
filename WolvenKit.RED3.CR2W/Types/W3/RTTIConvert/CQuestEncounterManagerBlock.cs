using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestEncounterManagerBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("encounterTag")] 		public CName EncounterTag { get; set;}

		[Ordinal(2)] [RED("enableEncounter")] 		public CBool EnableEncounter { get; set;}

		[Ordinal(3)] [RED("forceDespawnDetached")] 		public CBool ForceDespawnDetached { get; set;}

		[Ordinal(4)] [RED("encounterSpawnPhase")] 		public CName EncounterSpawnPhase { get; set;}

		public CQuestEncounterManagerBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestEncounterManagerBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}