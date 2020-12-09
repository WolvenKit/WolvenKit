using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestMappinStateBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("mappinEntry")] 		public CHandle<CJournalPath> MappinEntry { get; set;}

		[Ordinal(2)] [RED("enableOnlyIfLatest")] 		public CBool EnableOnlyIfLatest { get; set;}

		[Ordinal(3)] [RED("disableAllOtherMapPins")] 		public CBool DisableAllOtherMapPins { get; set;}

		public CJournalQuestMappinStateBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalQuestMappinStateBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}