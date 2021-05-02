using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalCreatureParams : CVariable
	{
		[Ordinal(1)] [RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[Ordinal(2)] [RED("autoEffects", 2,0)] 		public CArray<CName> AutoEffects { get; set;}

		[Ordinal(3)] [RED("buffImmunity")] 		public CBuffImmunity BuffImmunity { get; set;}

		[Ordinal(4)] [RED("monsterCategory")] 		public CInt32 MonsterCategory { get; set;}

		[Ordinal(5)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(6)] [RED("droppedItems", 2,0)] 		public CArray<CName> DroppedItems { get; set;}

		public SJournalCreatureParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}