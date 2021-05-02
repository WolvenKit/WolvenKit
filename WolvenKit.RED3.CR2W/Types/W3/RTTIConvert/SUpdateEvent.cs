using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SUpdateEvent : CVariable
	{
		[Ordinal(1)] [RED("eventType")] 		public CEnum<EUpdateEventType> EventType { get; set;}

		[Ordinal(2)] [RED("delay")] 		public CInt32 Delay { get; set;}

		[Ordinal(3)] [RED("journalBase")] 		public CHandle<CJournalBase> JournalBase { get; set;}

		[Ordinal(4)] [RED("index")] 		public CInt32 Index { get; set;}

		public SUpdateEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SUpdateEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}