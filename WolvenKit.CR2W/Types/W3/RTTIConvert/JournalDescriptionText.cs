using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class JournalDescriptionText : CVariable
	{
		[Ordinal(1)] [RED("order")] 		public CInt32 Order { get; set;}

		[Ordinal(2)] [RED("groupOrder")] 		public CInt32 GroupOrder { get; set;}

		[Ordinal(3)] [RED("stringKey")] 		public CInt32 StringKey { get; set;}

		[Ordinal(4)] [RED("currentEntry")] 		public CHandle<CJournalQuestDescriptionEntry> CurrentEntry { get; set;}

		public JournalDescriptionText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new JournalDescriptionText(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}