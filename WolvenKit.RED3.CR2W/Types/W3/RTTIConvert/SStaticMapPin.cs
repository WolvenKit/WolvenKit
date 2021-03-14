using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStaticMapPin : CVariable
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("iconType")] 		public CName IconType { get; set;}

		[Ordinal(3)] [RED("comment")] 		public CString Comment { get; set;}

		[Ordinal(4)] [RED("posX")] 		public CInt32 PosX { get; set;}

		[Ordinal(5)] [RED("posY")] 		public CInt32 PosY { get; set;}

		[Ordinal(6)] [RED("journalEntry")] 		public CSoft<CJournalResource> JournalEntry { get; set;}

		public SStaticMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStaticMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}