using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SJournalCreatureParams : CVariable
	{
		[RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		[RED("autoEffects", 2,0)] 		public CArray<CName> AutoEffects { get; set;}

		[RED("buffImmunity")] 		public CBuffImmunity BuffImmunity { get; set;}

		[RED("monsterCategory")] 		public CInt32 MonsterCategory { get; set;}

		[RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[RED("droppedItems", 2,0)] 		public CArray<CName> DroppedItems { get; set;}

		public SJournalCreatureParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SJournalCreatureParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}