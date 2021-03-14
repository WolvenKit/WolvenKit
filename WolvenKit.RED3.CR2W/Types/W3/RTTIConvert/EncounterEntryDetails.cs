using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EncounterEntryDetails : CVariable
	{
		[Ordinal(1)] [RED("encounterTag")] 		public CName EncounterTag { get; set;}

		[Ordinal(2)] [RED("canBeRepeated")] 		public CBool CanBeRepeated { get; set;}

		[Ordinal(3)] [RED("occurenceTime")] 		public CEnum<EOcurrenceTime> OccurenceTime { get; set;}

		[Ordinal(4)] [RED("questFileEntry", 2,0)] 		public CArray<CHandle<CEntityTemplate>> QuestFileEntry { get; set;}

		public EncounterEntryDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EncounterEntryDetails(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}