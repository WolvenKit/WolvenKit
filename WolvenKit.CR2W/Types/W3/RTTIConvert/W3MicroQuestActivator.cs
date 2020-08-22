using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MicroQuestActivator : CGameplayEntity
	{
		[RED("microQuestEntries", 2,0)] 		public CArray<EncounterEntryDetails> MicroQuestEntries { get; set;}

		[RED("selectedEntriesList", 2,0)] 		public CArray<EncounterEntryDetails> SelectedEntriesList { get; set;}

		[RED("chosenMicroQuestTag")] 		public CName ChosenMicroQuestTag { get; set;}

		[RED("isPlayerInArea")] 		public CBool IsPlayerInArea { get; set;}

		public W3MicroQuestActivator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MicroQuestActivator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}