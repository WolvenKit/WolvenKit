using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalCreature : CJournalContainer
	{
		[Ordinal(0)] [RED("name")] 		public LocalizedString Name { get; set;}

		[Ordinal(0)] [RED("image")] 		public CString Image { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CSoft<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("itemsUsedAgainstCreature", 2,0)] 		public CArray<CName> ItemsUsedAgainstCreature { get; set;}

		[Ordinal(0)] [RED("active")] 		public CBool Active { get; set;}

		public CJournalCreature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalCreature(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}