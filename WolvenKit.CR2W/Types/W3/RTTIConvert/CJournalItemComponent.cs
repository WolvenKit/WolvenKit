using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalItemComponent : CJournalContainerEntry
	{
		[RED("image")] 		public CString Image { get; set;}

		[RED("item")] 		public CName Item { get; set;}

		public CJournalItemComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJournalItemComponent(cr2w);

	}
}