using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalPath : ISerializable
	{
		[Ordinal(1)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(2)] [RED("resource")] 		public CSoft<CResource> Resource { get; set;}

		[Ordinal(3)] [RED("child")] 		public CHandle<CJournalPath> Child { get; set;}

		public CJournalPath(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalPath(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}