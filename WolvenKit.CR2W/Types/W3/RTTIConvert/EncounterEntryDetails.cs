using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EncounterEntryDetails : CVariable
	{
		[RED("encounterTag")] 		public CName EncounterTag { get; set;}

		[RED("canBeRepeated")] 		public CBool CanBeRepeated { get; set;}

		[RED("occurenceTime")] 		public CEnum<EOcurrenceTime> OccurenceTime { get; set;}

		[RED("questFileEntry", 2,0)] 		public CArray<CHandle<CEntityTemplate>> QuestFileEntry { get; set;}

		public EncounterEntryDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EncounterEntryDetails(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}