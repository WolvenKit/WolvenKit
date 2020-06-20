using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStaticMapPin : CVariable
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("iconType")] 		public CName IconType { get; set;}

		[RED("posX")] 		public CInt32 PosX { get; set;}

		[RED("posY")] 		public CInt32 PosY { get; set;}

		[RED("journalEntry")] 		public CSoft<CJournalResource> JournalEntry { get; set;}

		public SStaticMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStaticMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}