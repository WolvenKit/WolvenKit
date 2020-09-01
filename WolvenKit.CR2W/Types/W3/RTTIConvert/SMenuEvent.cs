using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMenuEvent : CVariable
	{
		[Ordinal(0)] [RED("("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("("openedMenu")] 		public CName OpenedMenu { get; set;}

		[Ordinal(0)] [RED("("openedJournalEntry")] 		public CHandle<CJournalBase> OpenedJournalEntry { get; set;}

		public SMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMenuEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}